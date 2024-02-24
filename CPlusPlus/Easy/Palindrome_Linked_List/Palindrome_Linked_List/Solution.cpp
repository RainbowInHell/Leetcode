#include <iostream>
#include <vector>

using namespace std;

struct ListNode {
    int val;
    ListNode* next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode* next) : val(x), next(next) {}
};

class Solution {
public:
    bool isPalindrome(ListNode* head)
    {
        vector<ListNode*> vectorOfNodes{ head };
        bool retVal = true;

        while (vectorOfNodes.back()->next != nullptr)
            vectorOfNodes.push_back(vectorOfNodes.back()->next);

        auto beginIt = vectorOfNodes.begin();
        auto endIt = vectorOfNodes.end() - 1;

        while (beginIt < endIt)
        {
            if ((*beginIt)->val != (*endIt)->val)
            {
                retVal = false;
                break;
            }

            endIt--;
            beginIt++;
        }

        return retVal;

        //First solution
        //vector<ListNode*> vectorOfNodes{ head };
        //vector<int> leftPart{};
        //vector<int> rightPart{};
        //bool retVal = true;

        //while (vectorOfNodes.back()->next != nullptr)
        //    vectorOfNodes.push_back(vectorOfNodes.back()->next);

        //for (int i = 0; i < vectorOfNodes.size() / 2; i++)
        //    leftPart.push_back(vectorOfNodes.at(i)->val);

        //for (int i = vectorOfNodes.size() / 2; i < vectorOfNodes.size(); i++)
        //    rightPart.push_back(vectorOfNodes.at(i)->val);

        //reverse(rightPart.begin(), rightPart.end());

        //for (int i = 0; i != vectorOfNodes.size() / 2; ++i)
        //{
        //    if (leftPart.at(i) != rightPart.at(i))
        //    {
        //        retVal = false;
        //        break;
        //    }
        //}

        //return retVal;
    }
};

int main()
{
    ListNode* listNode = new ListNode(1);
    listNode->next = new ListNode(2);
    listNode->next->next = new ListNode(3);
    listNode->next->next->next = new ListNode(2);
    listNode->next->next->next->next = new ListNode(1);

    Solution sol;
    cout << sol.isPalindrome(listNode);

    delete listNode;
}