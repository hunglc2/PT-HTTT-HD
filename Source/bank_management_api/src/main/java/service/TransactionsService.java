package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;

import model.Transactions;
import model.Account;
import model.Branch;
import model.HibernateUtils;
import model.TransactionTypes;
@Service
public class TransactionsService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<Transactions> getAll()
	{
        ArrayList<Transactions> lstResult = new ArrayList<Transactions>();
		try 
		{		
			Criteria cr = session.createCriteria(Transactions.class);
			List<Transactions> results =  cr.list();
			
			for (Transactions var : results) {
				var.setAccount(null);
				var.setBranch(null);
				var.setTransactionTypes(null);
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
	public Transactions getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(Transactions.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idTransactions", idObject));
			
			//modifier data -------------------
			List<Transactions> var = cr.list();
			var.get(0).setAccount(null);
			var.get(0).setBranch(null);
			var.get(0).setTransactionTypes(null);
		
			return  var.get(0);
        } catch (Exception e) {
            //e.printStackTrace();
            return null;
        }
	}
	
	public Transactions insert(Transactions vObject)
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
	
	public Transactions update(Transactions vObject)
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
	
	public Transactions delete(Transactions vObject)
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
