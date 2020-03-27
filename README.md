# DVHEquivalenceCalculator
Calculate EQD2 and BED DVHs with an external beam plan in Eclipse
///////////////////////////////////////////////////
// DVHEquivalenceCalculator.cs
//
// Looking up Calculated DVH Metrics
//
// Applies to Eclipse V15.6
// Built by Matthew Schmidt 
// for questions: (matthew.schmidt@wustl.edu)
// Current calculations
//  - GEUD - setup up as a dictionary of structure IDs and a parameters
//  - Homogeneity Index - For any structure with PTV in the ID
//
//
//DVHEquivalenceCalculator Copyright(c) 2020 Washington University. 
//Matthew Schmidt (matthew.schmidt@wustl.edu). Washington University hereby grants to you a non-transferable, non-exclusive, 
//royalty-free, non-commercial, research license to use and copy the computer code that may be downloaded 
//within this site (the “Software”).  You agree to include this license and the above copyright notice in all copies of the Software.  
//The Software may not be distributed, shared, or transferred to any third party.  
//This license does not grant any rights or licenses to any other patents, copyrights, 
//or other forms of intellectual property owned or controlled by Washington University.  
//If interested in obtaining a commercial license, please contact Washington University's Office of Technology Management (otm@wustl.edu).

 

//YOU AGREE THAT THE SOFTWARE PROVIDED HEREUNDER IS EXPERIMENTAL AND IS PROVIDED “AS IS”, 
//WITHOUT ANY WARRANTY OF ANY KIND, EXPRESSED OR IMPLIED, INCLUDING WITHOUT LIMITATION WARRANTIES 
//OF MERCHANTABILITY OR FITNESS FOR ANY PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF ANY THIRD-PARTY PATENT, 
//COPYRIGHT, OR ANY OTHER THIRD-PARTY RIGHT.  IN NO EVENT SHALL THE CREATORS OF THE SOFTWARE OR WASHINGTON UNIVERSITY BE LIABLE 
//FOR ANY DIRECT, INDIRECT, SPECIAL, OR CONSEQUENTIAL DAMAGES ARISING OUT OF OR IN ANY WAY CONNECTED WITH THE SOFTWARE, 
//THE USE OF THE SOFTWARE, OR THIS AGREEMENT, WHETHER IN BREACH OF CONTRACT, TORT OR OTHERWISE, 
//EVEN IF SUCH PARTY IS ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

 //Setup and use.
 //THE DVH Equivalency Calculator is a stand-alone executable. To run, setup initial parameters. In Visual Studio select Project-->Properties.
 //From the properties go to the Debug Section. In the Command Line Parameters Put in
 // "PatientId;CourseId;PlanId"
 //quotes are necessary if spaces are in course ID or Plan ID.
 //To run from External beam planning, use the DVHEquivalenceCalculator.cs file at the root of the project. Set the path to the path of the EXE on the server.

