package metier;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
public class ConnectMySql {
	

	Connection conn = null;
	public ConnectMySql() {
	try {
		try {
			Class.forName("com.mysql.jdbc.Driver").newInstance();
			System.out.println("Access to jdbc.Driver with success to MySql");
		} catch (InstantiationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	    conn =
	       DriverManager.getConnection("jdbc:mysql://localhost/library?" +
	                                   "user="+"root"+"&password="+"");
	    System.out.println("Connection with success to MySql");
	} catch (SQLException ex) {
	    System.out.println("SQLException: " + ex.getMessage());
	    System.out.println("SQLState: " + ex.getSQLState());
	    System.out.println("VendorError: " + ex.getErrorCode());
	}
	}
	
	public Connection getConnection(){
		return conn;
	}
}
