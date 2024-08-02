using Assignment3;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_EmptyMethod()
        {
            SLL<Node> sll = new SLL<Node>();

            bool expected = true;
            bool actual = sll.IsEmpty();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddFirstMethod() 
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            Node testNode = new Node(testUser);
            SLL<Node> sll = new SLL<Node>();
            sll.AddFirst(testUser);

            User expected = testUser;
            User actual = sll.Head.Value;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddLastMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");

            Node testNode = new Node(testUser);
            Node testNode2 = new Node(testUser2);

            SLL<Node> sll = new SLL<Node>();
            sll.AddFirst(testUser);
            sll.AddLast(testUser2);

            User expected = testUser2;
            User actual = sll.Tail.Value;

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_AddMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User testUser3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

            SLL<Node> sll = new SLL<Node>();
            sll.Add(testUser, 0);
            sll.Add(testUser2, 1);
            sll.Add(testUser3, 2);

            User expected = testUser2;
            User actual = sll.GetValue(1);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_ReplaceMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User testUser3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");


            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);
            sll.AddLast(testUser2);
            sll.Replace(testUser3, 1);

            User expected = testUser3;
            User actual = sll.GetValue(1);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_RemoveFirstMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);
            sll.AddLast(testUser2); 
            sll.RemoveFirst();

            User expected = testUser2;
            User actual = sll.Head.Value;

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_RemoveLastMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);
            sll.AddLast(testUser2);
            sll.RemoveLast();

            User expected = testUser;
            User actual = sll.GetValue(0);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_RemoveMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User testUser3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);
            sll.AddLast(testUser2);
            sll.Add(testUser3, 1);

            sll.Remove(1);

            User expected = testUser2;
            User actual = sll.GetValue(1);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Test_GetValueMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);

            sll.GetValue(0);

            User expected = testUser;
            User actual = sll.GetValue(0);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ContainsMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);

            bool expected = true;
            bool actual = sll.Contains(testUser);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_IndexOfMethod()
        {
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User testUser2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            User testUser3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

            SLL<Node> sll = new SLL<Node>();

            sll.AddFirst(testUser);
            sll.AddLast(testUser2);
            sll.Add(testUser3, 1);

            int expected = 2;
            int actual = sll.IndexOf(testUser2);

            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}