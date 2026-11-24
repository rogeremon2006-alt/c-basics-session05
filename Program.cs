using Assignment_4;

    Book b = new Book();
#region Q1
//Console.WriteLine(b.password);//error because it’s private
#endregion

#region Q2
Console.WriteLine(b.copiesInStock);//internal allows access from any class in the same project.
#endregion

#region Q3
b.Title = "The Great Gatsby";
Console.WriteLine(b.Title);
#endregion

#region Q4
b.Genre = Genre.Science;
Console.WriteLine(b.Genre);
#endregion

#region Q5
Console.WriteLine((int)Genre.Fiction);    
Console.WriteLine((int)Genre.NonFiction); 
Console.WriteLine((int)Genre.Science);
#endregion

#region Q6
int genreNumber = 1;
Genre genre = (Genre)genreNumber;
Console.WriteLine(genre);
#endregion

#region Q7
genre = Genre.Fiction;
string genreName = genre.ToString();
Console.WriteLine(genreName);
#endregion

#region Q8
string genreText = "Science";
Genre parsedGenre = Enum.Parse<Genre>(genreText);
Console.WriteLine(parsedGenre);
#endregion

#region Q9
genreText = "Mystery";
if (Enum.TryParse<Genre>(genreText, out Genre result))
    Console.WriteLine(result);
else
    Console.WriteLine("Unknown genre");

#endregion

