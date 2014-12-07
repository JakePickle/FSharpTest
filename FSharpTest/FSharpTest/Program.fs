// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open Octokit

let github = new GitHubClient(new ProductHeaderValue("name"))//Creates link to github

let releases = github.Release.GetAll("JakePickle", "GitHubUpdateTest")

let anInt = 5
let mutable num = 6
num <- anInt
let aString = "Hello" 
// Perform a simple calculation and bind anIntSquared to the result. 
let anIntSquared = anInt * anInt

System.Console.WriteLine(anInt)
System.Console.WriteLine(aString)
System.Console.WriteLine(anIntSquared)
System.Console.WriteLine(num)

let a = 9.0
let b = 6.0
let c = 5.0
let s = 0.5 * (a+b+c)
let k = sqrt(s*(s-a)*(s-b)*(s-c))
System.Console.WriteLine(k)

let mutable continueLooping = true 
let lookForValue value maxValue =
  while continueLooping do 
       continueLooping <- true

lookForValue 10 20