using Xunit;
using System;

namespace GradeBook.Tests
{

  public class TypeTests
  {
    
    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
      string myName = "John";
      var upper = MakeUpperCase(myName);

      Assert.Equal("JOHN", upper);
      Assert.Equal("John", myName);
    }

    private string MakeUpperCase(string parameter)
    {
      return parameter.ToUpper();
      
    }

    private void GetBookSetName(out Book book, string name)
    {
      book = new Book(name);
      
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }
    Book GetBook(string name)
    {
      return new Book(name);
    }

    int GetInt()
    {
      return 3;
    }

    private void SetInt(ref int z)
    {
      z = 42;
    }













    [Fact]
    public void TestName()
    {
      var x = GetInt();
      SetInt(ref x);

      Assert.Equal(42, x);
    }

    

    [Fact]
    public void CSharpCanPassByRef()
    {
      var book1 = GetBook("Book 1");
      GetBookSetName(out book1, "New Name");

      Assert.Equal("New Name", book1.Name);
      
    }

    // [Fact]
    // public void CSharpIsPassByValue()
    // {
    //   var book1 = GetBook("Book 1");
    //   GetBookSetName(out book1, "New Name");

    //   Assert.Equal("Book 1", book1.Name);
      
    // }



    [Fact]
    public void CanSetNameFromReference()
    {
      var book1 = GetBook("Book 1");
      SetName(book1, "New Name");

      Assert.Equal("New Name", book1.Name);
      
    }


    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
      Assert.NotSame(book2, book1);

    }

    [Fact]
    
    public void TwoVarsCanReferenceSameObjects()
    {
      var book1 = GetBook("Book 1");
      var book2 = book1;

      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
    }

  }
}