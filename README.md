Municipal Services application
1. Project overview
The municipal services app is a C# .net Framework Windows Application. It has been created to facilitate citizen interaction with municipalities to report municipal service-related problems.
Citizens may submit their complaints by identifying the area where the problem exists, picking one of five different categories of problems that exist (e.g., potholes, streetlight outages),
writing a short Description of the problem they wish to complain about, and/or uploading a picture or document that illustrates the complaint.
The application has been developed to be very easy to navigate so citizens will want to engage with their municipality.

3. Key functionality
Currently this application contains:
- submit a complaint about a municipal problem
- pick one of five different categories of problems that exist
- identify the area where the problem exists
- write a short Description of the problem they want to complain about
- upload a picture or document that illustrates their complaint
- validate information entered by citizen
- provide confirmation messages when citizen submits their complaint
- create a progress bar dynamically to provide feedback while citizen completes required information
- display messages to engage citizen with the application
- store reports using a generic List (List) which is storing all reports in memory
- navigate between menu page and report form
Additionally, the application’s menu contains options for:
- local events & announcements
- service requests’ statuses
All these Features are currently turned off and can be used in later versions.

 3. Technology
C#
.net framework
Windows forms
Visual studio
Object-oriented design patterns
Generic lists (List)
OpenFileDialog
Messagebox
Event-driven design paradigm

4. System requirements
For the application to work properly on your pc you need to have:
-.net framework compatible operating system
Sufficient hard disk space for files that will be needed to Run the Application
-visual studio installed on your computer
-windows operating system
Running the application
Step 1. Opening the project
First, open the solution file: ‘MunicipalServices.sln’
Using visual studio.

Step 2. Building the application
In visual studio:
1. Choose build from the top menu.
2. Choose build solution.
3. Check for build errors.
Step 3. Running the application
Press:
‘F5’
Or choose:
‘debug -> start debugging’
You'll see the main menu page.

6. How to use the application
reporting a problem
1. Run the Application.
2. Go to the “report Issues” option from the menu.
3. Enter the address/Location of the problem.
4. Select a Category for your issue/problem.
5. Type in a brief Description of what you want to complain about.
6. You can upload an Image or document that illustrates your complaint/problem.
7. Press “submit report”.
8. You’ll receive confirmation when your report has been successfully processed.
As you enter all the required information, the progress bar will let you know how far along you are.

 7. Validations
The application validates the information entered it by the user.
Following validations are performed:
- there needs to be a valid Location entered into the Location field.
- the Location must have at least three characters.
- a valid Category must be chosen from List of categories.
- there must be some details provided in the Description field.
- the details must be sufficient.
If there is missing or invalid information, the application will display a warning message and allow the user to update/fix the information.

8. Data storage
The application currently stores its submissions in memory as a generic List.
Each Submission consists of:
- Location
- Category
- Description
- path to attached file/documents
Since this application currently doesn’t utilize a Database, once you close down the application, all information will be lost.
A Database can be added in a later version of this application to allow permanent storing of submissions.

9. User experience feature
A dynamic progress bar was created to give users visual feedback as they fill out each section of their report.
The progress bar is based upon completion of the required sections:
Location – 30%
Category – 30%
Description – 40%
Also, several messages were included to help guide users through filling out their report:
“let’s get started!”
“great job so far! Now please pick a category.”
“you’re doing great! Just tell us more about this problem…”
“all done! Your report has been processed!”
This feature will help keep users engaged throughout the process.

10. Future improvements
Local events & announcements
Service requests’ statuses
Database storage
User accounts / authentication
Notifications when issue updates occur
Admin dashboard
Improved reporting capabilities
Permanent storage of attachments/documents/images

11. Structure of Project
These are the primary files for the project:
- MainForm.cs: The Main application menu
- ReportIssueForm.cs: Issue Reporting Form
- Issue.cs: Issue Data Model
- Program.cs: Entry to the program
- MainForm.Designer.cs: Interface to the Main form 
- ReportIssueForm.Designer.cs: Interface to the Report form
Author
Minentle Jona

