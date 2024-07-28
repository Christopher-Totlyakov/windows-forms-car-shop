# windows-forms-car-shop
A simple and easy example of how to handle Windows Forms. This example emphasizes Windows Forms functionality, so a plain text document is used as the database.

If you have problem loading and saving information to the text file check Form1.cs > FileStream fileStream = new FileStream("C:\\Users\\User\\Desktop\\Windows Forms Car shop\\data.txt", FileMode. Truncate, FileAccess.Write);
and StreamReader fileData = new StreamReader("C:\\Users\\User\\Desktop\\Windows Forms Car shop\\data.txt");
change the paths to your where you put the file.
