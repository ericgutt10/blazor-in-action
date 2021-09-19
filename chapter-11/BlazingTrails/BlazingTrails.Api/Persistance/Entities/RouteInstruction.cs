﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazingTrails.Api.Persistance.Entities;

public class RouteInstruction
{
    public int Id { get; set; }
    public int TrailId { get; set; }
    public int Stage { get; set; }
    public string Description { get; set; } = null!;

    public Trail Trail { get; set; } = null!;
}

public class RouteInstructionConfig : IEntityTypeConfiguration<RouteInstruction>
{
    public void Configure(EntityTypeBuilder<RouteInstruction> builder)
    {
        builder.Property(x => x.TrailId).IsRequired();
        builder.Property(x => x.Description).IsRequired();
    }
}
