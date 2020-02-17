package controller;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import javax.xml.ws.Endpoint;
import metier.ConnectMySql;
import model.User;

public  class Main {
	public static String urlBook="http://127.0.0.1:3347/";
	public static String urlUser="http://127.0.0.1:3315/";
	public static void main(String[] args)  {
		// TODO Auto-generated method stub
    // ConnectMySql conn=new ConnectMySql();
		Endpoint.publish(urlBook, new DAOBookService());
		System.out.println("Your service book deploued on "+urlBook);
		
    Endpoint.publish(urlUser, new DAOUserService());
	System.out.println("Your service User deploued on "+urlUser);
     User u=new User(1,"Ahmed","Ahmed123");
     DAOUserService DAOUser=new DAOUserService();
     //System.out.println(DAOUser.AddUser(u));
     //System.out.println(DAOUser.DeleteUser(2));
     List<User> users=DAOUser.RecupereUsers();
     for(int i = 0 ; i < users.size(); i++)
    	   System.out.println("id: "+users.get(i).getId_user()+" login :"+users.get(i).getLogin()+" password: "+users.get(i).getPassword());
	
	System.out.println(DAOUser.ModifyUser(u));
	}
}
