@ApisExample
Feature: ApisExample

@GETAllEmployees
Scenario: [01] - Get all employees
	Given I perform a GET request "<api request>" on the api to retrieve all employees
	And status code is "OK"
	And the statut is success
	And In the response's JSON body I have all employee

	Examples: 
	| api request                                       |
	| https://dummy.restapiexample.com/api/v1/employees |

@GETAnEmployee
Scenario: [02] - Get a specific employee
	Given I perform a GET request "<api request>" on the api to retrieve an employee
	And status code is "OK"
	And the statut is success
	And In the response's JSON body I have the employee data

	Examples: 
	| api request                                        |
	| https://dummy.restapiexample.com/api/v1/employee/1 |

@POSTAnEmployee
Scenario: [03] - Create a new employee
	Given I perform a POST request "<api request>" on the api 
	And status code is "OK"
	And the statut is success
	And In the response's JSON body I have the new employee information

	Examples: 
	| api request									 |
	| https://dummy.restapiexample.com/api/v1/create |

@UPDATEAnEmployee
Scenario: [04] - Update an existing employee
	Given I perform a PUT request "<api request>" on the api
	And status code is "OK"
	And the statut is success
	And  In the response's JSON body I have updated infos

	Examples: 
	| api request                                       |
	| https://dummy.restapiexample.com/api/v1/update/21 |

@DELETEAnEmployee
Scenario: [05] - Delete an employee
	Given I perform a DELETE request "<api request>" on the api
	And status code is "OK"
	And the statut is success
	And I can not perform a GET on this user

	Examples: 
	| api request                                     |
	| https://dummy.restapiexample.com/api/v1/delete/2 |


