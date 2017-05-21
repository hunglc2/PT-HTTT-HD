package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;

import model.Branch;
import model.HibernateUtils;
@Service
public class BranchService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<Branch> getAll()
	{
        ArrayList<Branch> lstResult = new ArrayList<Branch>();
		try 
		{		
			Criteria cr = session.createCriteria(Branch.class);
			List<Branch> results =  cr.list();
			
			for (Branch var : results) {
				var.setTransactionses(null);
				var.setEmployees(null);
				var.setAccounts(null);
				var.setSavingsAccounts(null);
				var.setCustomers(null);
				var.setOwner(null);
				lstResult.add(var);
            }
			
			return lstResult;
		} 
		catch (Exception e) 
		{
			//e.printStackTrace();
            return null;
		}
	}
	
	
	@SuppressWarnings({ "unchecked", "deprecation" })
	public Branch getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(Branch.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idBranch", idObject));
			
			//modifier data -------------------
			List<Branch> var = cr.list();
			var.get(0).setTransactionses(null);
			var.get(0).setEmployees(null);
			var.get(0).setAccounts(null);
			var.get(0).setSavingsAccounts(null);
			var.get(0).setCustomers(null);
			var.get(0).setOwner(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public Branch insert(Branch vObject)
	{
		
		try {
			//clear transaction ----------
			session.clear();
			//start transaction ----------
			session.beginTransaction();
			//body transaction -----------			
			session.persist(vObject);
			//commit transaction ---------
			session.getTransaction().commit();
			return vObject;
        } catch (Exception e) {
            //e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
	
	public Branch update(Branch vObject)
	{
		try {
			//clear transaction ---------
			session.clear();
			//start transaction ---------
			session.beginTransaction();
			//body transaction ----------
			session.update(vObject);
			//commit transaction --------
			session.getTransaction().commit();
			return vObject;
        } catch (Exception e) {
            //e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
	
	public Branch delete(Branch vObject)
	{
		try {
			//clear transaction ---------
			session.clear();
			//start transaction ---------
			session.beginTransaction();
			//body transaction ----------
			session.delete(vObject);
			//commit transaction --------
			session.getTransaction().commit();
			return vObject;
        } catch (Exception e) {
            //e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
}
