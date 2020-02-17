package controller;

import java.sql.SQLException;
import java.util.List;

import javax.jws.soap.SOAPBinding;
import javax.xml.ws.WebFault;

import model.Book;
@WebFault(faultBean = "com.mypackage.ws.exception.FaultBean")
public interface IDAOBookService {
	public String AddBook(Book b) ;
	public String ModifyBook(Book s);
	public String DeleteBook(int id) ;
	public List<Book> RecupereBooks()  ; 
	public List<String>RecupererAuthors() ;
}
