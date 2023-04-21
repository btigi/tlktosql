[![Build status](https://ci.appveyor.com/api/projects/status/ehq7d1k01nqufdjs?svg=true)](https://ci.appveyor.com/project/igi/tlktosql)

---

# TlkToSql

A command line utility to read string information from dialog.tlk files used Infinity Engine to an SQLite database


## Usage
``` 
tlktosql dialog.tlk game
```

**dialog.tlk**: path to the dialog.tlk file, e.g. /bgee/dialog.tlk

**game**: game name, used to classify strings in the datbase, e.g. bgee

## Download

You can [download](https://github.com/btigi/tlktosql/releases/) the latest version of tlktosql for Windows.


## Technologies

TlkToSql is written in C# Net Core 3.1.


## Compiling

To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET](https://dotnet.microsoft.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/btigi/tlktosql

# Go into the repository
$ cd tlktosql

# Build  the app
$ dotnet build
```


## Changes

0.7 Adds support for non-English dialog files.
 

## License

TlkToSql is licensed under [CC BY-NC 4.0](https://creativecommons.org/licenses/by-nc/4.0/)
 
