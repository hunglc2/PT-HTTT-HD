package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Session;

import model.Customer;
import model.HibernateUtils;
@Service
public class CustomerService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<Customer> getAll()
	{
        ArrayList<Customer> lstResult = new ArrayList<Customer>();
		try 
		{		
			Criteria cr = session.createCriteria(Customer.class);
			List<Customer> results =  cr.list();
			
			for (Customer var : results) {
				var.setBranch(null);
				var.setAccounts(null);
				var.setSavingsAccounts(null);
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
	public Customer getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(Customer.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idCustomer", idObject));
			
			//modifier data -------------------
			List<Customer> var = cr.list();
			var.get(0).setBranch(null);
			var.get(0).setAccounts(null);
			var.get(0).setSavingsAccounts(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public Customer insert(Customer vObject)
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
	
	public Customer update(Customer vObject)
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
	
	public Customer delete(Customer vObject)
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
