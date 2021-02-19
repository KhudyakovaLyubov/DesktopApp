# Cryptographer
Application for encrypt/decrypt files

## The purpose of the project:
This program allows you to encrypt / decrypt text files using the symmetric encryption type-TripleDES. 
The main functionality of the program: adding a file for the operation, entering a key (arbitrary) and starting the execution by clicking the " Run " button.
The program is executed in the Winforms template in the programming language C#.

### System requirements
###### Version: .NET framework 4.5

###### Resource requirements:
* Visual Studio (2016)
* Git

###### Required extensions:
* System.Text;
* System.Windows.Forms;
* System.IO;
* System.Security.Cryptography;

### User manual:
1. To start the program, you must select the source file and create a password.
2. Next, select the desired switch, depending on the desired operation, and then click the "start" button.
3. During the encryption process, the program launches a dialog box to save the results to a new file.
4. This is the end of the encryption/decryption operation.
5. The "cancel" button is necessary if you want to cancel the cipher execution operation.

###Documentation:
* [Metanit.com](https://metanit.com/sharp/windowsforms/1.1.php)
* [TripleDES](https://www.tutorialspoint.com/cryptography/triple_des.htm)
* [Теория по TripleDES](https://ru.wikipedia.org/wiki/Triple_DES#:~:text=Triple%20DES%20(3DES)%20%E2%80%94%20%D1%81%D0%B8%D0%BC%D0%BC%D0%B5%D1%82%D1%80%D0%B8%D1%87%D0%BD%D1%8B%D0%B9,%D0%B2%D0%B7%D0%BB%D0%BE%D0%BC%D0%B0%D0%BD%20%D0%BC%D0%B5%D1%82%D0%BE%D0%B4%D0%BE%D0%BC%20%D0%BF%D0%BE%D0%BB%D0%BD%D0%BE%D0%B3%D0%BE%20%D0%BF%D0%B5%D1%80%D0%B5%D0%B1%D0%BE%D1%80%D0%B0%20%D0%BA%D0%BB%D1%8E%D1%87%D0%B0.)
* [Реализация и методы на C# алгоритма шифрования TripleDES](https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.tripledes?view=net-5.0)
