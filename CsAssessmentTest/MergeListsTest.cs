using CsAssessment;

namespace CsAssessmentTest
{
    [TestClass]
    public sealed class MergeListsTest
    {
        MyListNodeImp _listNodeImp = new MyListNodeImp();

        [TestMethod]
        public void TestCase1()
        {
            List<int> list1 = [1, 2, 4];
            List<int> list2 = [1, 3, 4];
            List<int> expected = [1, 1, 2, 3, 4, 4];
            PassesExpectation(list1, list2, expected);
        }

        [TestMethod]
        public void TestCase2()
        {
            List<int> list1 = [];
            List<int> list2 = [];
            List<int> expected = [];
            PassesExpectation(list1, list2, expected);
        }

        [TestMethod]
        public void TestCase3()
        {
            List<int> list1 = [];
            List<int> list2 = [0];
            List<int> expected = [0];
            PassesExpectation(list1, list2, expected);
        }

        [TestMethod]
        public void TestCase4()
        {
            List<int> list1 = [1, 2, 4, 6, 7, 7, 8];
            List<int> list2 = [1, 3, 4, 6, 8, 8, 9];
            List<int> expected = [1, 1, 2, 3, 4, 4, 6, 6, 7, 7, 8, 8, 8, 9];
            PassesExpectation(list1, list2, expected);
        }

        private void PassesExpectation(List<int> list1, List<int> list2, List<int> expected)
        {
            ListNode listNode1 = CreateListNode(list1);
            ListNode listNode2 = CreateListNode(list2);
            ListNode result = _listNodeImp.MergeTwoLists(listNode1, listNode2);

            List<int> flattenedResult = FlattenNodeList(result);
            Assert.AreEqual(flattenedResult.Count, expected.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(flattenedResult[i], expected[i]);
            }
        }

        private ListNode CreateListNode(List<int> list)
        {
            List<ListNode> listNodes = list.Select(i => new ListNode { val = i }).ToList();

            if (listNodes != null && listNodes.Count >= 1)
            {
                ListNode listNode = listNodes.First();
                ListNode next = listNode;
                for (int i = 1; i < listNodes.Count; i++)
                {
                    next.next = listNodes[i];
                    next = next.next;
                }

                return listNode;
            }
            return null;
        }

        private List<int> FlattenNodeList(ListNode listNode)
        {
            List<int> list = new List<int>();

            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }


            return list;
        }
    }
}
