using System.ComponentModel;

namespace Entities.Enum;

public enum OrderStatuses
{
    [Description("Новый")]
    New = 1,
    [Description("Одобрено")]
    Approved,
    [Description("Отказано")]
    Rejected
}