review1.cs

int d; // elapsed time in days

// solution
int elapsedTimeInDays; 
------------------------------------------------------------------------------------------------------------
review2.cs

var dataFromDb = db.GetFromService().ToList(); // Get List of employees

//solution
var listOfEmployees = _employeeService.GetEmployeesFromService().ToList()
------------------------------------------------------------------------------------------------------------
review3.cs

int iCounter;
string strFullName;
DateTime dModifiedDate;

//solution
int counter;
string fullName;
DateTime modifiedDate;
------------------------------------------------------------------------------------------------------------
review4.cs

public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}

// solution
public bool IsShopOpen(string day, int amount)
{
    // some logic
}
------------------------------------------------------------------------------------------------------------
review5.cs

const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

// solution
const int daysInWeek= 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class Animal {}
class Alpaca {}
------------------------------------------------------------------------------------------------------------
review6.cs

public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

// solution
public class Employee
{
    public Datetime StartWorkDate { get; set; } // get set Start Working Date
    public Datetime modificationTime { get; set; } // get set Modification Time
}
------------------------------------------------------------------------------------------------------------
review7.cs

var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

//solution
var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}
------------------------------------------------------------------------------------------------------------
