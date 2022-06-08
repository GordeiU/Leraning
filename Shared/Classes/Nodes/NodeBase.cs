namespace Learning.Shared.Classes.Nodes {
    public abstract class NodeBase {
        public NodeBase(int value) {
            this.Value = value;
        }

        public abstract string GetTraverseString();

        public abstract bool Find(int value);

        public int Value { get; set; }
    }
}