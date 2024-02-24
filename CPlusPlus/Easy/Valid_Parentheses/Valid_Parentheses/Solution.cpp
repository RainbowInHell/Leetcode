#include <iostream>
#include <stack>
#include <unordered_map>

using namespace std;

class Solution {
public:
    bool isValid(string s)
    {
        if (s[0] == ')' ||
            s[0] == '}' ||
            s[0] == ']' ||
            s.length() % 2 != 0) return false;

        unordered_map<char, char> map{ {'(', ')'}, {'{', '}'}, {'[', ']'} };
        stack<char> stack;
        bool flag = false;

        for (int i = 0; i < s.length();)
        {
            if (s.at(i) == '(' || s.at(i) == '{' || s.at(i) == '[')
            {
                stack.push(s.at(i));
            }
            else
            {
                if (stack.empty() && s.length() - 1 > i)
                {
                    flag = false;
                    break;
                }

                if (map[stack.top()] == s.at(i))
                {
                    stack.pop();
                    flag = true;
                    i++;
                    continue;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            i++;
        }

        return stack.empty() && flag ? true : false;

    }
};

int main()
{
    //string s = "(({{{[]}{[]}{[]}[[]][{}][{}][()]()}}))";
    //string s = "[[[]";
    //string s = "()))";

    Solution sol;
    cout << sol.isValid("()))");
}