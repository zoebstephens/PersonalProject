# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to find out what villain they are for entertainment. 

### 3a ii.



My video demonstrates that my program can perform a personality quiz. 


### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. They enter a number 1 through 4. Then it outputs the result that correlates with the number chosen most often. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);

 int result = Program.AskQuestion(Quality);
            scores[result] = scores[result] + 1;           
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
int index = 0;
     foreach (int score in scores)
        {
             if (score > highestscore)
            {
                highestscore = scores[index];
                highestresult = results[index];
            }

                index = index + 1;
        }
``` 

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "scores".

### 3b iv.

Describes what the data contained in the list represents in your program

This list represents the different scores for the different options that the user can select. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing the scores index to select the result instead of using multiple if/else if statements. This makes the addition of more questions simpler instead of having to write another variable for each one. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
  public static int AskQuestion(Question question)
        {
            if (question == null)
            {
                throw new ArgumentNullException("Question can not be null");

            }

            List<string> answers = question.answers;

            if (answers.Count == 0)
            {
                throw new ArgumentException("The question must contain at least 1 option");
            }

            int ix = 1;
            foreach (string answer in answers)
            {
                Console.WriteLine($"{ix}. {answer}");
                ix = ix + 1;
            }

            // Display Question
            // Loop through each answer and display it 
            // Use GetValidAnswer method to get the user's response
            return GetValidAnswer(question.answers);
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
           AskQuestion(Color);

```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

This displays the question, the list of answers and waits for the user to input a valid answer. This is the main functionality of my program because it is used to display each question. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Validates the Question is not null
2. If Question is not null display the question
3. Iterate through each answer and display it
4. Use the GetValidAnswer method to get the user's response
5. Return the user's response


## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: AskQuestion(null);

**TODO: Complete this section**

Second call:  testQuestion = new Question();
            testQuestion.question = "Will Gretchen Pass her Bio Test";
            testQuestion.answers.Add("No");
            testQuestion.answers.Add("Yes, She will be late. ");
            testQuestion.answers.Add("She is 'sick' ");
            testQuestion.answers.Add("Of course!");


            result = Program.AskQuestion(testQuestion);




### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This will test if the input is null by throwing an exception. 

Condition(s) tested by the second call:

This tests that the method runs when the input is not null. 

### 3d iii.

Result of the first call: The result is an exception is thrown. 



Result of the second call:

The result is a question is asked and the user has to enter a valid answer. 