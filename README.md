# UnityDevelopment
Creating unity games.



#include <iostream>
#include <fstream>
using namespace std;
 
int main()
{
    ifstream input("f.txt");
    float ch;
    int Count = 0;
    while (input >> ch)
           cout << ch << endl;

    input.close();

    float *mass = new float[Count];
    ifstream file("f.txt");
    for(int i=0; i<Count; i++) {
    file>>mass[i];
    cout<<mass[i]<<endl;
    }

    delete []  mass;
    system("pause");
    return 0;
}
