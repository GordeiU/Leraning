namespace Learning.Shared.Classes.Nodes {
    public class SingleLinkedListNode : NodeBase {
        public SingleLinkedListNode(int value, SingleLinkedListNode? nextNode = null) : base(value) {
            Next = nextNode;
        }
 
        public SingleLinkedListNode? Next { get; set; }

        public override string GetTraverseString() {
            if (Next == null) {
                return Value.ToString();
            } else {
                return $"{Value} -> " + Next.GetTraverseString();
            }
        }

        public override bool Find(int targetValue) {
            if (Value == targetValue) {
                return true;
            }

            if (Next == null) {
                return false;
            }

            return Next.Find(targetValue);
        }
    }
}