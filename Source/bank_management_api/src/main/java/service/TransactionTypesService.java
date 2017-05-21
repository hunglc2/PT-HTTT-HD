package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;

import model.TransactionTypes;
import model.HibernateUtils;
@Service
public class TransactionTypesService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<TransactionTypes> getAll()
	{
        ArrayList<TransactionTypes> lstResult = new ArrayList<TransactionTypes>();
		try 
		{		
			Criteria cr = session.createCriteria(TransactionTypes.class);
			List<TransactionTypes> results =  cr.list();
			
			for (TransactionTypes var : results) {
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
	public TransactionTypes getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(TransactionTypes.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idTransactionTypes", idObject));
			
			//modifier data -------------------
			List<TransactionTypes> var = cr.list();
			var.get(0).setTransactionses(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public TransactionTypes insert(TransactionTypes vObject)
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
	
	public TransactionTypes update(TransactionTypes vObject)
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
	
	public TransactionTypes delete(TransactionTypes vObject)
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
