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
    ListNode* middleNode(ListNode* head) {
        vector<ListNode*> vectorOfNodes{ head };

        while (vectorOfNodes.back()->next != nullptr)
            vectorOfNodes.push_back(vectorOfNodes.back()->next);

        return vectorOfNodes[vectorOfNodes.size() / 2];
    }
};

int main()
{
    ListNode* listNode = new ListNode(5);
    listNode->next = new ListNode(10);
    listNode->next->next = new ListNode(15);
    listNode->next->next->next = new ListNode(20);
    listNode->next->next->next->next = new ListNode(25);

    Solution sol;
    cout << sol.middleNode(listNode)->val;
}