using System;

Main();
void Main(){


Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// As a question
// CanadaQuestion();
// EnthusiasticQuestion();
// LoveCSharpQuestion();
// SecretQuestion();

MooseResponse("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
MooseResponse("Are you enthuastic?", "Yay!", "You should try it!");
MooseResponse("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
MooseResponse("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

//refactored to own function below
// bool isTrue = MooseAsks("Is Canada real?");
// // Console.WriteLine(isTrue); <-- testing if we get true or false response back
// if (isTrue)
// {
//     MooseSays("Really? It seems very unlikely.");
// }
// else
// {
//     MooseSays("I  K N E W  I T !!!");
// }

//Function - JavaScript
// function MooseSays() {
//     return console.log()
// }

//Fat Arrow Function - JavaScript
// const MooseSays = () => {
//     return console.log()
// }

void MooseResponse(string question, string yesAnswer, string noAnswer) //we're looking for 3 string upon execution
{
    bool isQuestionTrue = MooseAsks(question);

    string answer = isQuestionTrue ? yesAnswer : noAnswer;

    MooseSays(answer);
}

//String interloption - ${message}
// void is a function without returning anything - an action like a verb
void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Not DRY code - all do same thing for questions
// //refactor to have question in own function
// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }