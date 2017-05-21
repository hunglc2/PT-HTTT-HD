package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Session;

import model.TypeSavingsAccount;
import model.HibernateUtils;
@Service
public class TypeSavingsAccountService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<TypeSavingsAccount> getAll()
	{
        ArrayList<TypeSavingsAccount> lstResult = new ArrayList<TypeSavingsAccount>();
		try 
		{		
			Criteria cr = session.createCriteria(TypeSavingsAccount.class);
			List<TypeSavingsAccount> results =  cr.list();
			
			for (TypeSavingsAccount var : results) {
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
	public TypeSavingsAccount getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(TypeSavingsAccount.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idTypeSavingsAccount", idObject));
			
			//modifier data -------------------
			List<TypeSavingsAccount> var = cr.list();
			var.get(0).setSavingsAccounts(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public TypeSavingsAccount insert(TypeSavingsAccount vObject)
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
	
	public TypeSavingsAccount update(TypeSavingsAccount vObject)
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
	
	public TypeSavingsAccount delete(TypeSavingsAccount vObject)
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
