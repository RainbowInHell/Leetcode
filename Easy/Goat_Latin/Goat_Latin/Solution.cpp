#include <string>
#include <sstream>
#include <iostream>
#include <vector>
#include <numeric>

using namespace std;

class Solution {
private:
    bool is_vowel[CHAR_MAX] = { false };

public:
    string toGoatLatin(string sentence) {

        is_vowel['A'] = true;
        is_vowel['a'] = true;

        is_vowel['E'] = true;
        is_vowel['e'] = true;

        is_vowel['I'] = true;
        is_vowel['i'] = true;

        is_vowel['o'] = true;
        is_vowel['O'] = true;

        is_vowel['U'] = true;
        is_vowel['u'] = true;

        istringstream iss(sentence);
        vector<string> results(istream_iterator<string>{iss}, istream_iterator<string>());

        string aToAdd = "a";

        for (auto& elem : results)
        {
            if (is_vowel[elem[0]])
            {
                elem += "ma";
            }
            else
            {
                char firstSymbol = elem[0];
                elem.erase(0, 1);
                elem += firstSymbol;
                elem += "ma";
            }

            elem += aToAdd;
            elem += ' ';
            aToAdd += "a";
        }

        string s = accumulate(results.begin(), results.end(), string{});
        s.pop_back();

        return s;
    }
};

int main()
{
    Solution sol;
    cout << sol.toGoatLatin("rYNjlt voFDXFVMxwTn OH");
}