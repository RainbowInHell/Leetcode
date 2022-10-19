#include <iostream>
#include <vector>
#include <algorithm>
#include <iterator>

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
	ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
		if (!list1) return list2;
		if (!list2) return list1;

		ListNode* t;
		if (list1->val < list2->val)
		{
			t = list1;
			list1 = list1->next;
		}
		else
		{
			t = list2;
			list2 = list2->next;
		}

		t->next = mergeTwoLists(list1, list2);
		return t;
	}
};

int main()
{
	ListNode* head = new ListNode(6);
	head->next = new ListNode(5);
	head->next->next = new ListNode(4);

	ListNode* head1 = new ListNode(3);
	head1->next = new ListNode(2);
	head1->next->next = new ListNode(1);

	Solution sol;
	ListNode* rofl =  sol.mergeTwoLists(head, head1);

}