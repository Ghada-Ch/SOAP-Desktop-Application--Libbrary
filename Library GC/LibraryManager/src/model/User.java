package model;

public class User {
	private int id_user;
	private String login;
	private String password;
	public User() {
		
	}
	public User(int id_user, String login, String password) {
		
		this.id_user = id_user;
		this.login = login;
		this.password = password;
	}
	public User(String login, String password) {
		super();
		this.login = login;
		this.password = password;
	}
	public int getId_user() {
		return id_user;
	}
	public void setId_user(int id_user) {
		this.id_user = id_user;
	}
	public String getLogin() {
		return login;
	}
	public void setLogin(String login) {
		this.login = login;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
	

}
