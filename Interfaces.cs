namespace Escape
{
    //Interface for Cartography
    interface ICartography
    {
        void UserName();
        void FirstRoom();
        void BlueRoom();
        string TreeRoom();
        string FightGuard(string path);
        string DetermineFightOutcome(string userAttack, string guardAttack);
    }

    // Interface for Drawing
    interface IDrawing
    {
        void Cart();
        void OldMan();
        void Tree();
        void Guards();
    }

    //Interface for Tips
    interface ITips
    {
        void FirstRoomTips(string tip);
    }
}
