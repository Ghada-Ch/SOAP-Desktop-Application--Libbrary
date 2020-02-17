package controller;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebService;

import metier.ConnectMySql;
import model.User;
@WebService
public class DAOUserService implements IDAOUserService {
	
	ConnectMySql conn=new ConnectMySql();
	
	public DAOUserService() {}
	@WebMethod
	@Override
	public  String AddUser(User u) {
		try {
		Statement state = conn.getConnection().createStatement();
		String requete="INSERT INTO user VALUES(Default,'"+u.getLogin()+"','"+u.getPassword()+"')";
		
		int i=state.executeUpdate(requete);
		 
		if(i==1)
		return "ADD WITH SUCCESS";
		else
	    return "ADD FAILED";
		}
		catch (SQLException e){
			e.printStackTrace();
			return "ADD FAILED";
		}
	}
	@WebMethod
	@Override
	public String ModifyUser(User u)  {
		try {
			Statement state = conn.getConnection().createStatement();
			String requete="UPDATE  user set login='"+u.getLogin()+"',password='"+u.getPassword()+"' where id_user="+u.getId_user();
			
			int i=state.executeUpdate(requete);
			 
			if(i==1)
			return "MODIFY WITH SUCCESS";
			else
		    return "MODIFY FAILED";
			}
			catch (SQLException e){
				e.printStackTrace();
				return "MODIFY FAILED";
			}
	}
	@WebMethod
	@Override
	public String DeleteUser(int id)  {
		String res=null;
		try {
			Statement state = conn.getConnection().createStatement();
			String requete="delete from user where id_user="+id;
			
			int i=state.executeUpdate(requete);
			 
			if(i==1)
			res= "DELETE WITH SUCCESS";
			else
		    res= "DELETE FAILED";
			}
			catch (SQLException e){
				e.printStackTrace();
				res= "DELETE FAILED";
			}
		
		return res;
		
	}
	@WebMethod
	@Override
	public List<User> RecupereUsers() {
		List<User> users = new ArrayList<User>();

		try {

        
        Statement stmt = conn.getConnection().createStatement();

        ResultSet rset = stmt.executeQuery( "SELECT * FROM user ");

        while (rset.next()) {
        	int id = rset.getInt("id_user");
            String login = rset.getString("login");
            String password = rset.getString("password");
            User user=new User(id,login,password);

            users.add(user);
        }

        
		}
		catch(SQLException e) {
			e.printStackTrace();
		}
        return users;
    }
	
	@WebMethod
	@Override
	public User find(String login,String password) {
		User user=null;
		try {

			
        Statement stmt = conn.getConnection().createStatement();

        ResultSet rset = stmt.executeQuery( "SELECT * FROM user where login='"+login+"' and password='"+password+"'");
       if(rset !=null) {
        while (rset.next()) {
        	int id = rset.getInt("id_user");
        
            user=new User(id,login,password);

           
        }
       }
        
		}
		catch(SQLException e) {
			e.printStackTrace();
		}
        return user;
    }

}
