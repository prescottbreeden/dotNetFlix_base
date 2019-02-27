using System;
using System.Collections.Generic;

namespace dotNetFlix.Models
{

  public class Customer
  {
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }

  public class Movie
  {
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
  }

  public class Dashboard
  {
    /* 
      this class will contain a list of movies and customers that we
      can pass to our index.cshtml -- implement your code below:
    */
    public List<Customer> Customers { get; set; }
    public List<Movie> Movies { get; set; }
  }
}