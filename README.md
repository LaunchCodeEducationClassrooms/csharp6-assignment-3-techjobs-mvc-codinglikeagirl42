# TechJobs, MVC Edition

This assignment asks the students to once again refactor a TechJobs application, this time using an MVC 
design pattern.

## Unit Tests

The starter code contains 4 unit test classes.  As with previous graded assignments, each test class was created for a specific task in the instructions.

`TestTaskTwo` verifies the work done to complete the List Views.  This includes displaying a list of jobs. **3 tests** are included in this test class.

`TestTaskThree` verifies work done to complete the `SearchController`.  This includes verifying how the `Results()` method was created and making sure that the method uses local variables.  This test class focuses on checking the student's implementation. **2 tests** are included in this test class.

`TestTaskFour` verifies the behaviors required for `Results()` to pass accurate data to a view. **2 tests** are included in this test class.  

### Troubleshooting Autograded Assignments

#### Student Output Matches the Example, But the Code Failed the Tests

* What does the test actually output say?
* Check for any extra or missing characters such as spaces, new lines, etc.
* Do all variable/method/etc names match what was presented in the textbook?
* Did they run all the tests or the ones for the section in question?
* Did they change a file that the instructions did not direct them to change?
* Do they need a break?

#### The Tests Passed, But Shouldn’t Have

* Does the code actually pass the test(s)?
* If the code is bad, have a student explain their code to you
* Ask for a demo and provide a new test case

## Score your students' work based on the following criteria:
 
### Appearance and Code Check:
 
This is an example of a [working demo app](https://csharp-mvc.launchcodetechnicaltraining.org/). This app was built in Java, but operates the same way as the completed C# app operates.
 
1. Have the student start their application.
1. Test the search functionality of the project:

    a. Ask the student to initiate a search by location, using the search term "new york". Only 1 result should be returned on the page. The result may vary in appearance, but make sure it contains the job data organized similar to this image:

    ![Search result](searchByLocation.png "Search Result Sample")  

    b.  Ask them to initiate another search by location, this time using the search term "chicago". Check that no results are returned.

    c. Ask to a search by employer this time, using the search term "equifax". 1 job should be returned.
    
    d. Ask for one more search term, this time searching by `all` for the term "Ruby". 4 results should be returned.
    
    e. Search for the same term, "Ruby" with the "Skill" category checked. This time, only 3 results should be returned.

1. Ask your student to show you their method for displaying the search results tested above.

    a. Be sure they can point you to their method within `SearchController`.
    
    b. Is that method posting to `"results"`?
    
    c. Does it make use of `findAll()` and `findByColumnAndValue()` appropriately? Or are they manipulating `JobData`?
    
    d. Ask them which strategy they have elected to use to display the jobs. Are they creating one table for all of the jobs displayed or one table per job?
 
1. Back in the running app, ask your student to navigate to the ``List`` view and have them select *View All*.

    a. A view of all 98 jobs should be returned. Ask them to scroll down to the end of the results to confirm.
 
1. Within the code, we give the students 2 options to accomplish the "View All" list. Be sure they can tell you which of these options they have chosen:
    
    a. An entry is added to `tableChoices` for the option to view all: `tableChoices.put("all", "View All");`
    
    b. The `list.html` template contains another table cell with the parameters hard-coded into a `th:href` for the view all view: `<a th:href="@{/list/jobs(column='All',value='View All')}">View All</a>`.
 
 
## Feedback and Grades:
  
Give your student a 1/1 score if they have met each of the requirements above. If, for some
reason, they have not completed each item, offer some advice on how to complete the assignment
or probe them to find out more about what could be blocking their progress. Make a plan to
have them demonstrate their work again when they have had time to make more progress.


