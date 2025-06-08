using Microsoft.EntityFrameworkCore;
using Presentation.Data;

namespace Presentation.Services;

public class EventService(DataContext context)
    {
    private readonly DataContext _context = context;

    public async Task<IEnumerable<EventEntity>> GetAllEventsAsync()
        {
        var entities = await _context.Events.ToListAsync();
        return entities;
        }

    public async Task<EventEntity?> GetAsync(string eventId)
        {
        var entity = await _context.Events.FirstOrDefaultAsync(x => x.Id == eventId);
        return entity;
        }
    }

