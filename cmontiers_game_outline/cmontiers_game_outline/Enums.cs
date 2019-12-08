
/// <summary>
/// This is the enum file, since enums are global, this
/// is where they can be stored to keep code clean
/// </summary>

enum gameState
{
    startMenu = 0,
    overworld,
    gamePlayFirst,
    gamePlaySecond,
    pauseMenu,
    victoryScreen,
    gameOver
}

enum playerState
{
    idle = 0,
    moveLeft,
    moveRight,
    moveUp,
    moveDown
}

enum enemyState
{
    idle = 0,
    moveLeft,
    moveRight,
    moveUp,
    moveDown,
    stunned
}