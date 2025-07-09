USE [petinsurance];
GO

-- Rename HealthRecordId to healthRecordId
EXEC sp_rename 'dbo.HealthRecordCondition.HealthRecordId', 'healthRecordId', 'COLUMN';
GO

-- Rename ConditionId to conditionId
EXEC sp_rename 'dbo.HealthRecordCondition.ConditionId', 'conditionId', 'COLUMN';
GO
