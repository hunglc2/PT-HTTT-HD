package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;

import model.Account;
import model.HibernateUtils;
@Service
public class AccountService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<Account> getAll()
	{
        ArrayList<Account> lstResult = new ArrayList<Account>();
		try 
		{		
			Criteria cr = session.createCriteria(Account.class);
			List<Account> results =  cr.list();
			
			for (Account var : results) {
				var.setAccountType(null);
				var.setBranch(null);
				var.setCustomer(null);
				var.setSavingsAccounts(null);
				var.setTransactionses(null);
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
	public Account getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(Account.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idAccount", idObject));
			
			//modifier data -------------------
			List<Account> var = cr.list();
			var.get(0).setAccountType(null);
			var.get(0).setBranch(null);
			var.get(0).setCustomer(null);
			var.get(0).setSavingsAccounts(null);
			var.get(0).setTransactionses(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public Account insert(Account vObject)
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
	
	public Account update(Account vObject)
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
	
	public Account delete(Account vObject)
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
