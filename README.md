# DVHEquivalenceCalculator

An application to convert DVHs into EQD2 or BED DVHs

Current calculations

- Scale DVH to EQD2 values
- Scale DVH to BED values
- Calculate EQD2 and BED values for specified DVH metrics.

## Getting Started

 THE DVH Equivalency Calculator is a stand-alone executable. To run, setup initial parameters. In Visual Studio select Project-->Properties.
 From the properties go to the Debug Section. In the Command Line Parameters Put in
 ```
 "PatientId;CourseId;PlanId"
 ```
 quotes are necessary if spaces are in course ID or Plan ID.
 Note the PatientId,etc. should be the ID of the object you're trying to open within Eclipse.
 To run from External beam planning, use the DVHEquivalenceCalculator.cs file at the root of the project. Set the path to the path of the EXE on the server.

### Prerequisites
DVHEquivalenceCalculator.cs
Applies to Eclipse V15.6
for questions: (matthew.schmidt@wustl.edu)
