package controller;

import java.sql.SQLException;
import java.util.List;

import model.User;

public interface IDAOUserService {
	public String AddUser(User b) ;
	public String ModifyUser(User s);
	public String DeleteUser(int id);
	public List<User> RecupereUsers() ;
	public User find(String login, String password); 
	
}
