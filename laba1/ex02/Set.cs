using System;

namespace ex02
{

    public class Set
    {
        private class Node
        {
            public int content;
            public Node next;
            public Node prev;

            public Node(int content)
            {
                this.content = content;
                this.next = null;
                this.prev = null;
            }

            public override string ToString()
            {
                return content.ToString();
            }
        }

        private Node head;
        private Node tail;

        public Set()
        {
            head = null;
            head = tail;
        }

        public Set(Set other)
        {
            this.head = null;
            this.tail = null;
            Node tmp = other.head;
            while (tmp != null)
            {
                this.add(tmp.content);
                tmp = tmp.next;
            }
        }

        public void add(int content)
        {
            if (head == null)
            {
                head = new Node(content);
                tail = head;
            } else
            {
                tail.next = new Node(content);
                tail.next.prev = tail;
                tail = tail.next;
            }
        }

        public void del(int content)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.content.Equals(content))
                {
                    if (tmp == tail)
                    {
                        if (tail.prev != null)
                        {
                            tail = tail.prev;
                            tail.next = null;
                        } else
                            tail = null;
                    }
                    else if (tmp == head)
                    {
                        head = head.next;
                        head.prev = null;
                    }
                    else
                    {
                        tmp.prev.next = tmp.next;
                        tmp.next.prev = tmp.prev;
                        tmp = null;
                    }
                    break;
                }
                tmp = tmp.next;
            }
        }

        public void printAll()
        {
            Node tmp = head;
            Console.Write("(");
            while (tmp != null && tmp.next != null)
            {
                Console.Write($"{tmp}, ");
                tmp = tmp.next;
            }
            Console.WriteLine($"{tmp})");
        }

        public bool have(int content)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.content == content)
                    return true;
                tmp = tmp.next;
            }
            return false;
        }

        public Set crossing(Set other)
        {
            Set union = new Set();

            Node tmp = head;
            while (tmp != null)
            {
                if (other.have(tmp.content))
                    union.add(tmp.content);
                tmp = tmp.next;
            }
            return union;
        }

        public Set union(Set other)
        {
            Set union = new Set();

            Node tmp = head;
            while (tmp != null)
            {
                union.add(tmp.content);
                tmp = tmp.next;
            }
            tmp = other.head;
            while (tmp != null)
            {
                if (!union.have(tmp.content))
                    union.add(tmp.content);
                tmp = tmp.next;
            }
            return union;
        }

        public static Set operator -(Set s1, Set s2)
        {
            Set dif = new Set(s1);

            Node tmp = s2.head;
            while (tmp != null)
            {
                dif.del(tmp.content);
                tmp = tmp.next;
            }
            return dif;
        }
    }
}
