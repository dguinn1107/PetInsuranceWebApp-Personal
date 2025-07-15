USE [petinsurance];
GO

-- Rename column 'name' to 'conditionName'
EXEC sp_rename 'dbo.HealthCondition.name', 'conditionName', 'COLUMN';
GO

-- Optional: Remove old conditionId column from HealthRecord (if ready)
ALTER TABLE dbo.HealthRecord
DROP COLUMN conditionId;
GO

-- Create junction table for many-to-many relation
CREATE TABLE dbo.HealthRecordCondition (
    HealthRecordId UNIQUEIDENTIFIER NOT NULL,
    ConditionId INT NOT NULL,
    CONSTRAINT PK_HealthRecordCondition PRIMARY KEY (HealthRecordId, ConditionId),

    CONSTRAINT FK_HRC_HealthRecord FOREIGN KEY (HealthRecordId)
        REFERENCES dbo.HealthRecord(healthRecordId)
        ON DELETE CASCADE,

    CONSTRAINT FK_HRC_Condition FOREIGN KEY (ConditionId)
        REFERENCES dbo.HealthCondition(conditionId)
        ON DELETE CASCADE
);
GO
