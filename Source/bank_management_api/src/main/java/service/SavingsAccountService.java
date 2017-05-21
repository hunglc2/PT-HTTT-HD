package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Session;

import model.SavingsAccount;
import model.HibernateUtils;
@Service
public class SavingsAccountService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<SavingsAccount> getAll()
	{
        ArrayList<SavingsAccount> lstResult = new ArrayList<SavingsAccount>();
		try 
		{		
			Criteria cr = session.createCriteria(SavingsAccount.class);
			List<SavingsAccount> results =  cr.list();
			
			for (SavingsAccount var : results) {
				var.setBranch(null);
				var.setAccount(null);
				var.setTypeSavingsAccount(null);
				var.setCustomer(null);
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
	public SavingsAccount getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(SavingsAccount.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idSavingsAccount", idObject));
			
			//modifier data -------------------
			List<SavingsAccount> var = cr.list();
			var.get(0).setBranch(null);
			var.get(0).setAccount(null);
			var.get(0).setTypeSavingsAccount(null);
			var.get(0).setCustomer(null);
			
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public SavingsAccount insert(SavingsAccount vObject)
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
            e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
	
	public SavingsAccount update(SavingsAccount vObject)
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
	
	public SavingsAccount delete(SavingsAccount vObject)
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
