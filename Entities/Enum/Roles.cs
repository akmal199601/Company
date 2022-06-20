using System.ComponentModel;

namespace Entities.Enum;

public enum Roles
{
    [Description("СуперАдминистратор")]
    SuperAdmin = 1,
    [Description("Администратор")]
    Admin,
    [Description("Пользователь")]
    User
}