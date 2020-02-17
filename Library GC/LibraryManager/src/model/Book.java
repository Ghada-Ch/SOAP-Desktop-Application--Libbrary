package model;

import javax.jws.WebMethod;

public class Book {
	private int id_book;
	private String titre;	
	private String auteur;
	private String genre;
	private float prix;
	private String language	;
	private String publisher;
	private int pages;
	public Book() {
	}
	public Book(int id_book, String titre, String auteur, String genre, float prix, String language, String publisher,int p) {
		
		this.id_book = id_book;
		this.titre = titre;
		this.auteur = auteur;
		this.genre = genre;
		this.prix = prix;
		this.language = language;
		this.publisher = publisher;
		this.pages=p;
	}
	public Book(String titre, String auteur, String genre, float prix, String language, String publisher,int p) {
	
		this.titre = titre;
		this.auteur = auteur;
		this.genre = genre;
		this.prix = prix;
		this.language = language;
		this.publisher = publisher;
		this.pages=p;
	}
	
	public int getId_book() {
		return id_book;
	}
	public void setId_book(int id_book) {
		this.id_book = id_book;
	}
	public String getTitre() {
		return titre;
	}
	public void setTitre(String titre) {
		this.titre = titre;
	}
	public String getAuteur() {
		return auteur;
	}
	public void setAuteur(String auteur) {
		this.auteur = auteur;
	}
	public String getGenre() {
		return genre;
	}
	public void setGenre(String genre) {
		this.genre = genre;
	}
	public float getPrix() {
		return prix;
	}
	public void setPrix(float prix) {
		this.prix = prix;
	}
	public String getLanguage() {
		return language;
	}
	public void setLanguage(String language) {
		this.language = language;
	}
	public String getPublisher() {
		return publisher;
	}
	public void setPublisher(String publisher) {
		this.publisher = publisher;
	}
	public int getPages() {
		return pages;
	}
	public void setPages(int pages) {
		this.pages = pages;
	}

}
