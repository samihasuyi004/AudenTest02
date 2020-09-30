Feature: AudenTestFeature1
	

@AudenTest
Scenario: Apply for Monthly Loan Installment
	Given i am on Auden Homepage and select loan Amount and Repayment day
	And i should see the first repayment date text as 'Tuesday 13 Oct 2020'
	And i should see the Min as 200 and Max 500
	And the selected slider amount is the loan Amount