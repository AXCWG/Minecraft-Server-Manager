using System.Text.Json;
using System.Runtime.InteropServices;
using RconSharp;
using System.Security.Authentication;
using Newtonsoft.Json;
using System.Collections;
using System.Numerics;

namespace WinFormsApp1;
public class Config 
{
    public  List<Instance> Instance { get; set; }
    
}
public class Instance
{
    public BigInteger id {  get; set; }
    public  string Host { get; set; }

    
}
public class Rootobject
{
    public bool online { get; set; }
    public string ip { get; set; }
    public int port { get; set; }
    public string hostname { get; set; }
    public Debug debug { get; set; }
    public string version { get; set; }
    public Protocol protocol { get; set; }
    public string icon { get; set; }
    public string software { get; set; }
    public Map map { get; set; }
    public string gamemode { get; set; }
    public string serverid { get; set; }
    public bool eula_blocked { get; set; }
    public Motd motd { get; set; }
    public Players players { get; set; }
    public Plugin[] plugins { get; set; }
    public Mod[] mods { get; set; }
    public Info info { get; set; }
}

public class Debug
{
    public bool ping { get; set; }
    public bool query { get; set; }
    public bool srv { get; set; }
    public bool querymismatch { get; set; }
    public bool ipinsrv { get; set; }
    public bool cnameinsrv { get; set; }
    public bool animatedmotd { get; set; }
    public bool cachehit { get; set; }
    public int cachetime { get; set; }
    public int cacheexpire { get; set; }
    public int apiversion { get; set; }
}

public class Protocol
{
    public int version { get; set; }
    public string name { get; set; }
}

public class Map
{
    public string raw { get; set; }
    public string clean { get; set; }
    public string html { get; set; }
}

public class Motd
{
    public string[] raw { get; set; }
    public string[] clean { get; set; }
    public string[] html { get; set; }
}

public class Players
{
    public int online { get; set; }
    public int max { get; set; }
    public List[] list { get; set; }
}

public class List
{
    public string name { get; set; }
    public string uuid { get; set; }
}

public class Info
{
    public string[] raw { get; set; }
    public string[] clean { get; set; }
    public string[] html { get; set; }
}

public class Plugin
{
    public string name { get; set; }
    public string version { get; set; }
}

public class Mod
{
    public string name { get; set; }
    public string version { get; set; }
}

public static class Program
{
    public static Config config;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // Took me a million years to figure out how to initialize a class like this; 
        //var config = new Config
        //{
        //    Instance = new Instance[]
        //    {
        //        new Instance
        //        {
        //            id = 0,
        //            Host = "localhost",
        //        },
        //        new Instance
        //        {
        //            id = 1, 
        //            Host = "localhost",
        //        }
        //    }
        //};


        var json = File.ReadAllText("json.json");
        config = JsonConvert.DeserializeObject<Config>(json);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        


    }
    public static void Save()
    {
        config.Instance.Add(new Instance
        {
            id = config.Instance.Count() + 1,
            Host = "play.earthmc.net"
        });
        File.WriteAllText("json.json", JsonConvert.SerializeObject(config));
    }

}

public class custom
{

    public static async Task<Rootobject> API(string serveraddress)
    {
        Console.WriteLine("Start of API");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://api.mcsrvstat.us/3/");
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage response = client.GetAsync(serveraddress).Result;
        Rootobject rootobject = await System.Text.Json.JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
        
        Console.WriteLine("End of API");
        return rootobject;



    }
}
public class Rcons
{
    static RconClient client2;
    public async static Task<Rcons> InitRcon(string host, string port, string password)
    {
        var client = new Rcons(RconClient.Create(host, Int32.Parse(port.Trim())));
        await client2.ConnectAsync();
        var authenticated = await client2.AuthenticateAsync(password);
        if (authenticated)
        {
            return client;
        }
        else
        {
            throw new AuthenticationException("Authentication error. ");

        }

    }
    private Rcons(RconClient rconClient)
    {
        client2 = rconClient;
    }
    public async static Task<string> io(string input)
    {
        
            return await client2.ExecuteCommandAsync(input, false);

       
    }
    
}