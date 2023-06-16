using AvaloniaMyApp.Models;
using AvaloniaMyApp.Models;

namespace AvaloniaMyApp;

public class Service
{
    private static YarAppContext? _db;
    public static YarAppContext  GetDbContext()
    {
        if (_db == null)
        {
            _db = new YarAppContext();
        }
        return _db;
    }
}