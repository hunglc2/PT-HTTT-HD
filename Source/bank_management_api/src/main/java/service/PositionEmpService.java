package service;

import org.hibernate.SessionFactory;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Service;
import java.util.ArrayList;
import java.util.List;
import org.hibernate.Criteria;
import org.hibernate.Session;

import model.PositionEmp;
import model.HibernateUtils;
@Service
public class PositionEmpService {
	static SessionFactory factory = HibernateUtils.getSessionFactory();
    static Session session = factory.openSession();
    
	@SuppressWarnings({ "deprecation", "unchecked" })
	public ArrayList<PositionEmp> getAll()
	{
        ArrayList<PositionEmp> lstResult = new ArrayList<PositionEmp>();
		try 
		{		
			Criteria cr = session.createCriteria(PositionEmp.class);
			List<PositionEmp> results =  cr.list();
			
			for (PositionEmp var : results) {
				var.setEmployees(null);
				lstResult.add(var);
            }
			
			return lstResult;
		} 
		catch (Exception e) 
		{
			e.printStackTrace();
            return null;
		}
	}
	
	
	@SuppressWarnings({ "unchecked", "deprecation" })
	public PositionEmp getByID(int idObject)
	{
		try {
			
			Criteria cr = session.createCriteria(PositionEmp.class);
			//condition ----------------------
			cr.add(Restrictions.eq("idPosition", idObject));
			
			//modifier data -------------------
			List<PositionEmp> var = cr.list();
			var.get(0).setEmployees(null);
		
			return  var.get(0);
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
	}
	
	public PositionEmp insert(PositionEmp vObject)
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
	
	public PositionEmp update(PositionEmp vObject)
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
            e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
	
	public PositionEmp delete(PositionEmp vObject)
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
            e.printStackTrace();
            session.getTransaction().rollback();
            return null;
        }
	}
}
