package controller;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebService;

import metier.ConnectMySql;
import model.Book;
import javax.xml.ws.WebFault;

@WebFault(faultBean = "com.mypackage.ws.exception.FaultBean")
@WebService
public class DAOBookService  implements IDAOBookService {

	ConnectMySql conn=new ConnectMySql();
	@WebMethod
	@Override
	public  String AddBook(Book b)  {
		try {
			Statement state = conn.getConnection().createStatement();
			String requete="INSERT INTO book VALUES(Default,'"+b.getTitre()+"','"+b.getAuteur()+"','"+b.getGenre()+"',"+b.getPrix()+",'"+b.getLanguage()+"','"+b.getPublisher()+"',"+b.getPages()+")";
			
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
	public  String ModifyBook(Book b)  {
		try {
			Statement state = conn.getConnection().createStatement();
			String requete="Update  book set titre='"+b.getTitre()+"',auteur='"+b.getAuteur()+"',genre='"+b.getGenre()+"',prix="+b.getPrix()+",language='"+b.getLanguage()+"',publisher='"+b.getPublisher()+"',pages="+b.getPages()+" where id_book="+b.getId_book();
			
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
	public String DeleteBook(int id)  {
		String res=null;
		try {
			Statement state = conn.getConnection().createStatement();
			String requete="delete from book where id_book="+id;
			
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
	public List<Book> RecupereBooks()  {
		List<Book> books = new ArrayList<Book>();

		try {

        
        Statement stmt = conn.getConnection().createStatement();

        ResultSet rset = stmt.executeQuery( "SELECT * FROM book ");
       
        while (rset.next()) {
        	int id_book = rset.getInt("id_book");
            String titre = rset.getString("titre");
            String auteur = rset.getString("auteur");
            String genre = rset.getString("genre");
            float prix = rset.getFloat("prix");
            String language = rset.getString("language");
            String publisher = rset.getString("publisher");
            int pages = rset.getInt("pages");

            Book book=new Book(id_book,titre,auteur,genre,prix,language,publisher,pages);

            books.add(book);
        }

        
		}
		catch(SQLException e) {
			e.printStackTrace();
		}
        return books;
	}
	@WebMethod
	@Override
	public List<String> RecupererAuthors()  {
		// TODO Auto-generated method stub
		return null;
	}

}
