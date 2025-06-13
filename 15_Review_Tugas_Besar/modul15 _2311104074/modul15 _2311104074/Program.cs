using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string filePath = "users.json";

    static void Main()
    {
        Console.WriteLine("1. Register\n2. Login\nChoose: ");
        var choice = Console.ReadLine();
        if (choice == "1") Register();
        else if (choice == "2") Login();
    }

    static void Register()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        if (!Regex.IsMatch(username, @"^[a-zA-Z]+$"))
        {
            Console.WriteLine("Username hanya boleh huruf alfabet!");
            return;
        }

        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (password.Length < 8 || password.Length > 20)
        {
            Console.WriteLine("Password harus 8-20 karakter!");
            return;
        }

        if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
        {
            Console.WriteLine("Password harus mengandung minimal 1 karakter unik (!@#$%^&*)");
            return;
        }

        if (password.ToLower().Contains(username.ToLower()))
        {
            Console.WriteLine("Password tidak boleh mengandung username!");
            return;
        }

        string hash = HashPassword(password);
        var users = LoadUsers();
        users.Add(new User { Username = username, PasswordHash = hash });
        SaveUsers(users);
        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();
        string hash = HashPassword(password);

        var users = LoadUsers();
        foreach (var user in users)
        {
            if (user.Username == username && user.PasswordHash == hash)
            {
                Console.WriteLine("Login berhasil!");
                return;
            }
        }

        Console.WriteLine("Login gagal!");
    }

    static string HashPassword(string password)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
    }

    static List<User> LoadUsers()
    {
        if (!File.Exists(filePath)) return new List<User>();
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    static void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
