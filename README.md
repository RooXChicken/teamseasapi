# teamseasapi
A simple #TeamSeas API written in C#

# How to
Just put the `teamseasapi.cs` file somewhere, `using namespace teamseasapi` or `teamseasapi.` and you're good to go.
The only function right now (and probably forever) is `GetTotalDonated` taking in a boolean of true or false. If true, it will have commas, if false, it will be a straight integer.

## Sample code:
```
static void Main()
{
    Console.WriteLine(GetTotalDonated(true)); //true for comma formatting, false for straight ingeter
}
```

Have fun!
