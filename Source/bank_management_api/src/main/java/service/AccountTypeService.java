package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;

import model.AccountType;
import model.HibernateUtils;
@Service
public class AccountTypeService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<AccountType> getAll()
	{
        ArrayList<AccountType> lstResult = new ArrayList<AccountType>();
		try 
		{		
			Criteria cr = session.createCriteria(AccountType.class);
			List<AccountType> results =  cr.list();
			
			for (AccountType var : results) {
				var.setAccounts(null);
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
	public AccountType getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(AccountType.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idAccountType", idObject));
			
			//modifier data -------------------
			List<AccountType> var = cr.list();
			var.get(0).setAccounts(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public AccountType insert(AccountType vObject)
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
	
	public AccountType update(AccountType vObject)
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
	
	public AccountType delete(AccountType vObject)
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
