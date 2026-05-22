using System;
using System.Reflection.Metadata;
using QueryCollection;
using setofprograms;
namespace CSharpPrograms1
{

    [TestClass]
    public sealed class TestQuryCollection
    {
        LinqClass linq;
        AllCollections allcollections;

        [TestInitialize]
        public void Initialize()
        {
            linq = new LinqClass();
            allcollections = new AllCollections();

        }

        [TestMethod]
        public void test_filter_on_employee_salary()
        {
            linq.filteremp_highsal(linq.get_employees());
        }
        //All non Generic Collections
        [TestMethod]
        public void test_arraylist()
        {
            allcollections.ArrayListExample();
        }
        [TestMethod]
        public void test_hashtable()
        {
            allcollections.HashtableExample();
        }
        [TestMethod]
        public void test_stack()
        {
            allcollections.StackExample();
        }
        [TestMethod]
        public void test_queue()
        {
            allcollections.QueueExample();

        }
        [TestMethod]
        public void test_display_employee_names()
        {
            linq.display_employee_names(linq.get_employees());
        }
        [TestMethod]
        public void test_sort_employee_salary()
        {
            linq.sort_employee_salary(linq.get_employees(), 'a');
            linq.sort_employee_salary(linq.get_employees(), 'd');
        }
       
        //All Generic Methods
        [TestMethod]
        public void test_generic_list()
        {
            allcollections.ListExample();
        }
        [TestMethod]
        public void test_generic_dictionary()
        {
            allcollections.DictionaryExample();
        }
         [TestMethod]
         public void test_generic_stack()
         {
                allcollections.StackExample();
         }
        [TestMethod]
        public void test_generic_queue()
        {
            allcollections.GenericQueueExample();
        }
        [TestMethod]
        public void test_generic_sortedlist()
        {
            allcollections.GenericStackExample();
        }

        [TestMethod]
        public void test_generic_hashset()
        {
            allcollections.HashSetExample();
        }



        [TestMethod]
        public void test_generic_linkedlist()
        {
            allcollections.LinkedListExample();
        }


        }
    }
