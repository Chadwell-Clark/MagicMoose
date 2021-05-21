using System;

Main();

void Main()
{

    MooseSays("Welcome weary bushwacker. I am the Magical Moose of Mystery!");
    Question();

}

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
                       |   / \   |   {message}
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

void Question()
{
    Console.Write("Ask me any question and I will answer!  ");

    string inquiry = Console.ReadLine();
    Answer(inquiry);
    Console.WriteLine();
}

void Answer(string inquiry)
{
    string[] answers =
    { "As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
"Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.'",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
"Yes.",
"Yes – definitely.",
"You may rely on it." };
    Random r = new Random();
    if (!String.IsNullOrEmpty(inquiry))
    {
        int mooseMagic = r.Next(answers.Length);
        Console.WriteLine(answers[mooseMagic]);
        Console.WriteLine();
        Question();
    }
}
