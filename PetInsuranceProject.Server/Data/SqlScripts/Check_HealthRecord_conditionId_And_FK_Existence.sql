-- Check if conditionId column still exists
SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'HealthRecord' AND COLUMN_NAME = 'conditionId';

-- Check if foreign key constraint still exists
SELECT * 
FROM sys.foreign_keys
WHERE name = 'FK_HealthRecord_HealthCondition';
