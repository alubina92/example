int count = 0;
int distance = 10000;
int ffs = 1;
int sfs = 2;
int ds = 5;
int friends = 2;
int time = 0;
while(distance > 10)
{
    if(friends == 1)
    {
        time = distance / (ffs + ds);
        friends = 2;
    }
    else
    {
        time = distance / (sfs + ds);
        friends = 1;
    }
    distance = distance - (ffs + sfs)*time;
    count = count + 1;
}

Console.WriteLine(count);

