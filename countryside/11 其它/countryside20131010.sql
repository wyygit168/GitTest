USE [countryside]
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Title__5224328E]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Title__5224328E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Title__5224328E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Provin__531856C7]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Provin__531856C7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Provin__531856C7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Status__540C7B00]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Status__540C7B00]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Status__540C7B00]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__OrderV__55009F39]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__OrderV__55009F39]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__OrderV__55009F39]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Remark__55F4C372]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Remark__55F4C372]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Remark__55F4C372]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Creato__56E8E7AB]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Creato__56E8E7AB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Creato__56E8E7AB]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Create__57DD0BE4]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Create__57DD0BE4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Create__57DD0BE4]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Modifi__58D1301D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Modifi__58D1301D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Modifi__58D1301D]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Modify__59C55456]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Modify__59C55456]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] DROP CONSTRAINT [DF__areacity__Modify__59C55456]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Title__44CA3770]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Title__44CA3770]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Title__44CA3770]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Provi__45BE5BA9]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Provi__45BE5BA9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Provi__45BE5BA9]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__CityI__46B27FE2]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__CityI__46B27FE2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__CityI__46B27FE2]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Statu__47A6A41B]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Statu__47A6A41B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Statu__47A6A41B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Order__489AC854]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Order__489AC854]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Order__489AC854]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Remar__498EEC8D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Remar__498EEC8D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Remar__498EEC8D]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Creat__4A8310C6]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Creat__4A8310C6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Creat__4A8310C6]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Creat__4B7734FF]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Creat__4B7734FF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Creat__4B7734FF]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Modif__4C6B5938]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Modif__4C6B5938]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Modif__4C6B5938]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Modif__4D5F7D71]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Modif__4D5F7D71]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] DROP CONSTRAINT [DF__areacount__Modif__4D5F7D71]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Title__395884C4]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Title__395884C4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Title__395884C4]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Statu__3A4CA8FD]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Statu__3A4CA8FD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Statu__3A4CA8FD]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Order__3B40CD36]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Order__3B40CD36]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Order__3B40CD36]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Remar__3C34F16F]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Remar__3C34F16F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Remar__3C34F16F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Creat__3D2915A8]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Creat__3D2915A8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Creat__3D2915A8]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Creat__3E1D39E1]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Creat__3E1D39E1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Creat__3E1D39E1]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Modif__3F115E1A]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Modif__3F115E1A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Modif__3F115E1A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Modif__40058253]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Modif__40058253]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] DROP CONSTRAINT [DF__areaprovi__Modif__40058253]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Title__2B0A656D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Title__2B0A656D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Title__2B0A656D]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Provin__2BFE89A6]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Provin__2BFE89A6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Provin__2BFE89A6]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__CityID__2CF2ADDF]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__CityID__2CF2ADDF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__CityID__2CF2ADDF]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__County__2DE6D218]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__County__2DE6D218]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__County__2DE6D218]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Status__2EDAF651]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Status__2EDAF651]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Status__2EDAF651]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__OrderV__2FCF1A8A]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__OrderV__2FCF1A8A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__OrderV__2FCF1A8A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Remark__30C33EC3]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Remark__30C33EC3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Remark__30C33EC3]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Creato__31B762FC]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Creato__31B762FC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Creato__31B762FC]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Create__32AB8735]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Create__32AB8735]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Create__32AB8735]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Modifi__339FAB6E]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Modifi__339FAB6E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Modifi__339FAB6E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Modify__3493CFA7]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Modify__3493CFA7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] DROP CONSTRAINT [DF__areatown__Modify__3493CFA7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Title__1BC821DD]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Title__1BC821DD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Title__1BC821DD]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Provi__1CBC4616]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Provi__1CBC4616]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Provi__1CBC4616]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__CityI__1DB06A4F]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__CityI__1DB06A4F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__CityI__1DB06A4F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Count__1EA48E88]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Count__1EA48E88]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Count__1EA48E88]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__TownI__1F98B2C1]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__TownI__1F98B2C1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__TownI__1F98B2C1]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Statu__208CD6FA]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Statu__208CD6FA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Statu__208CD6FA]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Order__2180FB33]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Order__2180FB33]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Order__2180FB33]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Remar__22751F6C]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Remar__22751F6C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Remar__22751F6C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Creat__236943A5]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Creat__236943A5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Creat__236943A5]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Creat__245D67DE]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Creat__245D67DE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Creat__245D67DE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Modif__25518C17]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Modif__25518C17]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Modif__25518C17]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Modif__2645B050]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Modif__2645B050]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] DROP CONSTRAINT [DF__areavilla__Modif__2645B050]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Custo__02084FDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Custo__02084FDA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Custo__02084FDA]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Domai__02FC7413]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Domai__02FC7413]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Domai__02FC7413]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Statu__03F0984C]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Statu__03F0984C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Statu__03F0984C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Order__04E4BC85]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Order__04E4BC85]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Order__04E4BC85]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Remar__05D8E0BE]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Remar__05D8E0BE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Remar__05D8E0BE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Creat__06CD04F7]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Creat__06CD04F7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Creat__06CD04F7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Creat__07C12930]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Creat__07C12930]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Creat__07C12930]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Modif__08B54D69]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Modif__08B54D69]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Modif__08B54D69]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Modif__09A971A2]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Modif__09A971A2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] DROP CONSTRAINT [DF__system_cu__Modif__09A971A2]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__RoleI__71D1E811]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__RoleI__71D1E811]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__RoleI__71D1E811]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__MenuI__72C60C4A]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__MenuI__72C60C4A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__MenuI__72C60C4A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Custo__73BA3083]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Custo__73BA3083]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__Custo__73BA3083]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsSho__74AE54BC]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsSho__74AE54BC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsSho__74AE54BC]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsPur__75A278F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsPur__75A278F5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsPur__75A278F5]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsAdd__76969D2E]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsAdd__76969D2E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsAdd__76969D2E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsVie__778AC167]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsVie__778AC167]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsVie__778AC167]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsEdi__787EE5A0]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsEdi__787EE5A0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsEdi__787EE5A0]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsDel__797309D9]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsDel__797309D9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__IsDel__797309D9]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Creat__7A672E12]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Creat__7A672E12]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__Creat__7A672E12]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Creat__7B5B524B]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Creat__7B5B524B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__Creat__7B5B524B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Modif__7C4F7684]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Modif__7C4F7684]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__Modif__7C4F7684]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Modif__7D439ABD]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Modif__7D439ABD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] DROP CONSTRAINT [DF__system_ro__Modif__7D439ABD]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__UserI__6754599E]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__UserI__6754599E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__UserI__6754599E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__RoleI__68487DD7]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__RoleI__68487DD7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__RoleI__68487DD7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Custo__693CA210]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Custo__693CA210]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__Custo__693CA210]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Creat__6A30C649]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Creat__6A30C649]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__Creat__6A30C649]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Creat__6B24EA82]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Creat__6B24EA82]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__Creat__6B24EA82]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Modif__6C190EBB]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Modif__6C190EBB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__Modif__6C190EBB]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Modif__6D0D32F4]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Modif__6D0D32F4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] DROP CONSTRAINT [DF__system_us__Modif__6D0D32F4]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Title__0880433F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Title__0880433F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Title__0880433F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Statu__09746778]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Statu__09746778]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Statu__09746778]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__LinkM__0A688BB1]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__LinkM__0A688BB1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__LinkM__0A688BB1]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Phone__0B5CAFEA]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Phone__0B5CAFEA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Phone__0B5CAFEA]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Mobil__0C50D423]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Mobil__0C50D423]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Mobil__0C50D423]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcustom__QQ__0D44F85C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcustom__QQ__0D44F85C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcustom__QQ__0D44F85C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcusto__Fax__0E391C95]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcusto__Fax__0E391C95]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcusto__Fax__0E391C95]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_Email]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_Email]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_Email]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Addre__0F2D40CE]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Addre__0F2D40CE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Addre__0F2D40CE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Order__10216507]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Order__10216507]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Order__10216507]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_ProvinceID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_ProvinceID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_ProvinceID]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_CityID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_CityID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_CityID]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_CountyID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_CountyID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_CountyID]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_TownID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_TownID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_TownID]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Remar__11158940]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Remar__11158940]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Remar__11158940]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_OpenStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_OpenStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF_systemcustomer_OpenStatus]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Creat__1209AD79]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Creat__1209AD79]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Creat__1209AD79]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Creat__12FDD1B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Creat__12FDD1B2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Creat__12FDD1B2]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Modif__13F1F5EB]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Modif__13F1F5EB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Modif__13F1F5EB]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Modif__14E61A24]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Modif__14E61A24]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] DROP CONSTRAINT [DF__systemcus__Modif__14E61A24]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Title__46E78A0C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Title__46E78A0C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Title__46E78A0C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Statu__47DBAE45]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Statu__47DBAE45]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Statu__47DBAE45]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Order__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Order__48CFD27E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Order__48CFD27E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Remar__49C3F6B7]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Remar__49C3F6B7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Remar__49C3F6B7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Creat__4AB81AF0]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Creat__4AB81AF0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Creat__4AB81AF0]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Creat__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Creat__4BAC3F29]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Creat__4BAC3F29]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Modif__4CA06362]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Modif__4CA06362]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Modif__4CA06362]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Modif__4D94879B]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Modif__4D94879B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] DROP CONSTRAINT [DF__systemdom__Modif__4D94879B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Custo__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Custo__52E34C9D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Custo__52E34C9D]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Title__53D770D6]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Title__53D770D6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Title__53D770D6]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__MenuU__54CB950F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__MenuU__54CB950F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__MenuU__54CB950F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_Alt]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_Alt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF_systemmenu_Alt]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_IsSuperAdmin]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_IsSuperAdmin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF_systemmenu_IsSuperAdmin]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__IsTop__55BFB948]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__IsTop__55BFB948]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__IsTop__55BFB948]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__TopMe__56B3DD81]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__TopMe__56B3DD81]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__TopMe__56B3DD81]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Paren__57A801BA]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Paren__57A801BA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Paren__57A801BA]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_MenuType]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_MenuType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF_systemmenu_MenuType]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Statu__59904A2C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Statu__59904A2C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Statu__59904A2C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Order__5A846E65]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Order__5A846E65]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Order__5A846E65]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Remar__5B78929E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Remar__5B78929E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Remar__5B78929E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Creat__5C6CB6D7]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Creat__5C6CB6D7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Creat__5C6CB6D7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Creat__5D60DB10]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Creat__5D60DB10]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Creat__5D60DB10]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Modif__5E54FF49]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Modif__5E54FF49]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Modif__5E54FF49]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Modif__5F492382]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Modif__5F492382]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] DROP CONSTRAINT [DF__systemmen__Modif__5F492382]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Custo__276EDEB3]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Custo__276EDEB3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Custo__276EDEB3]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Title__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Title__286302EC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Title__286302EC]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Statu__29572725]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Statu__29572725]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Statu__29572725]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Order__2A4B4B5E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Order__2A4B4B5E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Order__2A4B4B5E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Remar__2B3F6F97]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Remar__2B3F6F97]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Remar__2B3F6F97]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Creat__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Creat__2C3393D0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Creat__2C3393D0]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Creat__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Creat__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Creat__2D27B809]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Modif__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Modif__2E1BDC42]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Modif__2E1BDC42]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Modif__2F10007B]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Modif__2F10007B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] DROP CONSTRAINT [DF__systemrol__Modif__2F10007B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Custo__251C81ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Custo__251C81ED]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Custo__251C81ED]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Title__2610A626]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Title__2610A626]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Title__2610A626]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_Password]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_Password]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF_systemuser_Password]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_RealName]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_RealName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF_systemuser_RealName]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_IdentityCard]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_IdentityCard]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF_systemuser_IdentityCard]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_UserSex]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_UserSex]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF_systemuser_UserSex]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Statu__2704CA5F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Statu__2704CA5F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Statu__2704CA5F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Phone__27F8EE98]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Phone__27F8EE98]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Phone__27F8EE98]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Mobil__28ED12D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Mobil__28ED12D1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Mobil__28ED12D1]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuser__QQ__29E1370A]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuser__QQ__29E1370A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuser__QQ__29E1370A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_UserEmail]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_UserEmail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF_systemuser_UserEmail]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Addre__2AD55B43]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Addre__2AD55B43]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Addre__2AD55B43]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Order__2BC97F7C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Order__2BC97F7C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Order__2BC97F7C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Remar__2CBDA3B5]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Remar__2CBDA3B5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Remar__2CBDA3B5]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Creat__2DB1C7EE]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Creat__2DB1C7EE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Creat__2DB1C7EE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Creat__2EA5EC27]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Creat__2EA5EC27]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Creat__2EA5EC27]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Modif__2F9A1060]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Modif__2F9A1060]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Modif__2F9A1060]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Modif__308E3499]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Modif__308E3499]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] DROP CONSTRAINT [DF__systemuse__Modif__308E3499]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__MenuI__6C390A4C]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__MenuI__6C390A4C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__MenuI__6C390A4C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Custo__6D2D2E85]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Custo__6D2D2E85]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Custo__6D2D2E85]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Statu__6F1576F7]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Statu__6F1576F7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Statu__6F1576F7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Order__70099B30]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Order__70099B30]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Order__70099B30]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_web_customer_menu_CreatorID]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_web_customer_menu_CreatorID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF_web_customer_menu_CreatorID]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Creat__70FDBF69]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Creat__70FDBF69]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Creat__70FDBF69]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Modif__71F1E3A2]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Modif__71F1E3A2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Modif__71F1E3A2]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Modif__72E607DB]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Modif__72E607DB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] DROP CONSTRAINT [DF__web_custo__Modif__72E607DB]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Title__02C769E9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Title__02C769E9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Title__02C769E9]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Custo__03BB8E22]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Custo__03BB8E22]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Custo__03BB8E22]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__TownI__04AFB25B]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__TownI__04AFB25B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__TownI__04AFB25B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Villa__05A3D694]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Villa__05A3D694]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Villa__05A3D694]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Statu__0697FACD]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Statu__0697FACD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Statu__0697FACD]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webbeautifulvillage_Intro]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webbeautifulvillage_Intro]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF_webbeautifulvillage_Intro]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Yield__078C1F06]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Yield__078C1F06]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Yield__078C1F06]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautifulv__Live__0880433F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautifulv__Live__0880433F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautifulv__Live__0880433F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Envir__09746778]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Envir__09746778]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Envir__09746778]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Human__0A688BB1]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Human__0A688BB1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Human__0A688BB1]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Order__0B5CAFEA]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Order__0B5CAFEA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Order__0B5CAFEA]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Creat__0C50D423]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Creat__0C50D423]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Creat__0C50D423]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Creat__0D44F85C]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Creat__0D44F85C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Creat__0D44F85C]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Modif__0E391C95]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Modif__0E391C95]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Modif__0E391C95]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Modif__0F2D40CE]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Modif__0F2D40CE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] DROP CONSTRAINT [DF__beautiful__Modif__0F2D40CE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Title__6319B466]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Title__6319B466]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Title__6319B466]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Custo__640DD89F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Custo__640DD89F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Custo__640DD89F]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__TownI__6501FCD8]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__TownI__6501FCD8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__TownI__6501FCD8]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Villa__65F62111]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Villa__65F62111]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Villa__65F62111]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Statu__66EA454A]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Statu__66EA454A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Statu__66EA454A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileT__67DE6983]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileT__67DE6983]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__FileT__67DE6983]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileU__68D28DBC]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileU__68D28DBC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__FileU__68D28DBC]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webbeautifulvillageFile_LinkUrl]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webbeautifulvillageFile_LinkUrl]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF_webbeautifulvillageFile_LinkUrl]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileR__69C6B1F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileR__69C6B1F5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__FileR__69C6B1F5]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Order__6ABAD62E]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Order__6ABAD62E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Order__6ABAD62E]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Creat__6BAEFA67]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Creat__6BAEFA67]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Creat__6BAEFA67]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Creat__6CA31EA0]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Creat__6CA31EA0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Creat__6CA31EA0]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Modif__6D9742D9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Modif__6D9742D9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Modif__6D9742D9]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Modif__6E8B6712]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Modif__6E8B6712]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] DROP CONSTRAINT [DF__webbeauti__Modif__6E8B6712]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Custo__70A8B9AE]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Custo__70A8B9AE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Custo__70A8B9AE]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Title__719CDDE7]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Title__719CDDE7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Title__719CDDE7]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Conte__72910220]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Conte__72910220]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Conte__72910220]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Opert__73852659]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Opert__73852659]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Opert__73852659]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Statu__74794A92]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Statu__74794A92]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Statu__74794A92]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Order__756D6ECB]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Order__756D6ECB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Order__756D6ECB]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Provi__76619304]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Provi__76619304]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Provi__76619304]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__CityI__7755B73D]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__CityI__7755B73D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__CityI__7755B73D]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Count__7849DB76]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Count__7849DB76]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Count__7849DB76]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__TownI__793DFFAF]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__TownI__793DFFAF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__TownI__793DFFAF]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Villa__7A3223E8]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Villa__7A3223E8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Villa__7A3223E8]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Creat__7B264821]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Creat__7B264821]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Creat__7B264821]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Creat__7C1A6C5A]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Creat__7C1A6C5A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Creat__7C1A6C5A]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Modif__7D0E9093]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Modif__7D0E9093]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Modif__7D0E9093]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Modif__7E02B4CC]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Modif__7E02B4CC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] DROP CONSTRAINT [DF__webfarmin__Modif__7E02B4CC]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Title__61BB7BD9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Title__61BB7BD9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__Title__61BB7BD9]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Status__62AFA012]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Status__62AFA012]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__Status__62AFA012]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webmenu_Url]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webmenu_Url]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF_webmenu_Url]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__OrderVa__63A3C44B]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__OrderVa__63A3C44B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__OrderVa__63A3C44B]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Creator__6497E884]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Creator__6497E884]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__Creator__6497E884]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__CreateD__658C0CBD]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__CreateD__658C0CBD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__CreateD__658C0CBD]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Modifie__668030F6]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Modifie__668030F6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__Modifie__668030F6]
END


End
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__ModifyD__6774552F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__ModifyD__6774552F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] DROP CONSTRAINT [DF__webmenu__ModifyD__6774552F]
END


End
GO
/****** Object:  Table [dbo].[areacity]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areacity]') AND type in (N'U'))
DROP TABLE [dbo].[areacity]
GO
/****** Object:  Table [dbo].[areacounty]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areacounty]') AND type in (N'U'))
DROP TABLE [dbo].[areacounty]
GO
/****** Object:  Table [dbo].[areaprovince]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areaprovince]') AND type in (N'U'))
DROP TABLE [dbo].[areaprovince]
GO
/****** Object:  Table [dbo].[areatown]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areatown]') AND type in (N'U'))
DROP TABLE [dbo].[areatown]
GO
/****** Object:  Table [dbo].[areavillage]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areavillage]') AND type in (N'U'))
DROP TABLE [dbo].[areavillage]
GO
/****** Object:  Table [dbo].[system_customer_domain]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_customer_domain]') AND type in (N'U'))
DROP TABLE [dbo].[system_customer_domain]
GO
/****** Object:  Table [dbo].[system_role_menu]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_role_menu]') AND type in (N'U'))
DROP TABLE [dbo].[system_role_menu]
GO
/****** Object:  Table [dbo].[system_user_role]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_user_role]') AND type in (N'U'))
DROP TABLE [dbo].[system_user_role]
GO
/****** Object:  Table [dbo].[systemcustomer]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemcustomer]') AND type in (N'U'))
DROP TABLE [dbo].[systemcustomer]
GO
/****** Object:  Table [dbo].[systemdomain]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemdomain]') AND type in (N'U'))
DROP TABLE [dbo].[systemdomain]
GO
/****** Object:  Table [dbo].[systemlog]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemlog]') AND type in (N'U'))
DROP TABLE [dbo].[systemlog]
GO
/****** Object:  Table [dbo].[systemmenu]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemmenu]') AND type in (N'U'))
DROP TABLE [dbo].[systemmenu]
GO
/****** Object:  Table [dbo].[systemrole]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemrole]') AND type in (N'U'))
DROP TABLE [dbo].[systemrole]
GO
/****** Object:  Table [dbo].[systemuser]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemuser]') AND type in (N'U'))
DROP TABLE [dbo].[systemuser]
GO
/****** Object:  Table [dbo].[web_customer_menu]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[web_customer_menu]') AND type in (N'U'))
DROP TABLE [dbo].[web_customer_menu]
GO
/****** Object:  Table [dbo].[webbeautifulvillage]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]') AND type in (N'U'))
DROP TABLE [dbo].[webbeautifulvillage]
GO
/****** Object:  Table [dbo].[webbeautifulvillageFile]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]') AND type in (N'U'))
DROP TABLE [dbo].[webbeautifulvillageFile]
GO
/****** Object:  Table [dbo].[webfarmingnews]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webfarmingnews]') AND type in (N'U'))
DROP TABLE [dbo].[webfarmingnews]
GO
/****** Object:  Table [dbo].[webmenu]    Script Date: 10/10/2013 22:27:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webmenu]') AND type in (N'U'))
DROP TABLE [dbo].[webmenu]
GO
/****** Object:  Table [dbo].[webmenu]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webmenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[webmenu](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Url] [varchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](1000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__webmenu__6B2329655FD33367] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'网站菜单自增长ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'''''' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webmenu', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webmenu', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[webmenu] ON
INSERT [dbo].[webmenu] ([AutoID], [Title], [Status], [Url], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'首页', 1, N'index/', 1, N'', 1, CAST(0x0000A1CC00F39451 AS DateTime), 1, CAST(0x0000A1FD016A0552 AS DateTime))
INSERT [dbo].[webmenu] ([AutoID], [Title], [Status], [Url], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'资讯速递', 1, N'news/0/', 0, N'', 1, CAST(0x0000A1CD00EA06FB AS DateTime), 1, CAST(0x0000A23A00F656E0 AS DateTime))
INSERT [dbo].[webmenu] ([AutoID], [Title], [Status], [Url], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'魅力乡村', 1, N'village/0/', 0, N'', 1, CAST(0x0000A22A01687F85 AS DateTime), 1, CAST(0x0000A22B01770A96 AS DateTime))
SET IDENTITY_INSERT [dbo].[webmenu] OFF
/****** Object:  Table [dbo].[webfarmingnews]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webfarmingnews]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[webfarmingnews](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](200) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Content] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Opertype] [tinyint] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[CountyID] [int] NOT NULL,
	[TownID] [int] NOT NULL,
	[VillageID] [int] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__webfarmi__6B2329656EC0713C] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'三农资讯自增长ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'Content'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'Content'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'Opertype'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'业务类型，0：法律法规，1：地方资讯' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'Opertype'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'ProvinceID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属省' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'CityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属城市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'CityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'CountyID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属县' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'CountyID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'TownID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属乡镇' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'TownID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'VillageID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属乡村' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'VillageID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webfarmingnews', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webfarmingnews', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[webfarmingnews] ON
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 0, N'梁寨供电积极做好“两节”期间保供电工作', N'<p>
 &ldquo;中秋&rdquo;、&ldquo;国庆&rdquo;佳节即将来临。为了确保&ldquo;两节&rdquo;期间的电网安全稳定运行以及重要用户的电力可靠供应，江苏省电力公司丰县供电公司梁寨供电所根据工作职能，全力部署制定了&ldquo;两节&rdquo;保供电工作。提前筹备，成立了保供电领导小组，制定了《&ldquo;两节&rdquo;保供电工作方案》，全面做好&ldquo;两节&rdquo;期间保电工作。</p>
<p>
 　　一是制定节前保电措施，提前做好节日期间安全保供电准备工作，做到早安排、早部署、早落实。</p>
<p>
 　　二是开展用电安全大检查活动。对供电辖区内的配电设施进行了全面排查，对线路电流、电压测量，对线路老化程度进行检查，及时消除隐患。通过对供电设施的隐患排查和整改，确保线路设备处于良好的运行状态。</p>
<p>
 　　三是合理安排电网运行方式。该所加强对配电运行设备的监视和维护，做好负荷预测，保证节日期间居民正常用电。</p>
<p>
 　　四是加强节日期间值班制度，要求值班人员和车辆全天待命，积极应对各类应急事件，为&ldquo;两节&rdquo;期间安全供电提供保障。同时，积极主动与有关部门沟通联系，及时掌握&ldquo;两节&rdquo;期间重要活动安排，确定重点保电范围。针对重要保电客户，要求各供电所在节日期间认真开展优质服务，对客户反映的故障信息及时处理，树立良好的社会形象。</p>
', 1, 1, 12, 4, 1, 1, 1, 0, 1, CAST(0x0000A1E0017FA456 AS DateTime), 1, CAST(0x0000A23B010B0864 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 0, N'梁寨镇根根蒜薹变金条', N'<div align="left">
	<font face="宋体" size="2">&nbsp;&nbsp; &ldquo;五一&rdquo;过后，梁寨镇喜获丰收的四万亩苔蒜销售临近尾声，让蒜农有惊无险的是，今春虽然持续干旱，眼看蒜薹懒抽歉收，但由于该镇及时开闸放水，保证了四万亩苔蒜遇旱不减产。蒜薹上市以来，八方客商慕名而来，梁满路上车水马龙、商贾云集，早晚甚至出现堵车现象。蒜薹销售一月以来，市场价格一直持续在5元/千克以上，最高幅达到10元/千克的高位。</font></div>
<div>
	<font face="宋体" size="2">&nbsp;&nbsp;&nbsp; 蒜薹一般亩产600千克左右，可高达800千克以上。按照今年的市场价格，该镇农民蒜薹亩收益3000&mdash;&mdash;5000元，再加上附属产品蒜头，一般亩收益不低于4000元。赵楼、孟楼、千井等村户均种植苔蒜3亩以上，仅此一项收入就过万元。该镇喜不自胜的蒜农逢人就说：&ldquo;我们提的是蒜薹，流的是汗，吃的是苦，但卖的是钱。&lsquo;黄土变成金&rsquo;在我们镇已不再是神话！&rdquo;(</font></div>
', 1, 1, 12, 4, 1, 1, 1, 1, 1, CAST(0x0000A1E101071B37 AS DateTime), 1, CAST(0x0000A23B011B6E36 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 0, N'三农快报，农民的生活益友，三农快报，农民的生活', N'<p>
	三农快播 论坛</p>
', 0, 1, 0, 4, 1, 1, 1, 0, 1, CAST(0x0000A1E101080479 AS DateTime), 1, CAST(0x0000A20E00FAAB4B AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, 0, N'梁寨镇探索长效机制应对环境整治“顽疾”', N'<p>
	梁寨镇把建立环境综合整治长效机制作为工作的出发点和落脚点，通过加强组织领导，建立专职队伍，健全规章制度，落实目标责任，解决环境卫生&ldquo;脏、乱、差&rdquo;的问题，应对镇村环境综合整治&ldquo;顽疾&rdquo;。<br />
	&nbsp;&nbsp;&nbsp; 为实施镇村&ldquo;靓化&rdquo;工程，该镇成立了以分管领导任组长、城管队、村建服务站负责人及20个环境整治村书记为成员的镇村环境综合整治领导小组，组建了镇村环境综合整治执法大队，选聘了40名责任心强、热爱环卫事业的环卫工人，健全了规章制度，落实了个体经营户和沿街住户门前承包责任制，明确全镇20个行政村要落实好&ldquo;三个一&rdquo;，即成立一支卫生保洁队、设立一处垃圾集中场、一个村一套卫生管理公约为主要内容的卫生管理机制。突出整理&ldquo;四乱&rdquo;和&ldquo;三清&rdquo;（柴草乱堆、垃圾乱倒、污水乱泼、畜禽乱跑、清洁河道、清洁村庄、清洁家园）等重点工作，确保实现了村内垃圾户装村集，镇处理，日产日清。（责任编辑：李芳）</p>
', 1, 1, 0, 4, 1, 1, 1, 0, 1, CAST(0x0000A1FE0118DB09 AS DateTime), 1, CAST(0x0000A23B01124C2E AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, 0, N'梁寨镇严明纪律轻松过双节', N'<p>
	双节临近，梁寨镇要求全体党员领导干部认真落实廉洁自律各项规定，大力弘扬勤俭节约良好风尚，坚决刹住&ldquo;双节&rdquo;期间公款送节礼、公款吃喝、公款旅游和奢侈浪费等不正之风，营造文明祥和、风清气正的节日氛围，从过去一过节就迎来送往的辛苦中解脱出来，轻松过双节。<br />
	&nbsp;&nbsp;&nbsp; 该镇党委书记王磊在会议上强调，一是要严格执行廉洁自律各项规定。全镇党员干部要以身作则、率先垂范，严格执行《廉政准则》规定的8个禁止52个不准要求，以实际行动切实转变作风、厉行节约。二是要坚决制止铺张浪费和奢侈享乐。严禁用公款搞相互走访、相互送礼、相互宴请等拜访活动；严禁用公款大吃大喝、旅游和参与高消费娱乐、健身活动；严禁公车接送学生、探亲访友等公车私用、公车私驾行为；严禁以各种名义发津贴、补贴、奖金、实物；严禁举办各类没有实效的节庆、节会；严禁领导干部及其配偶、子女利用其职权或者职务影响收受礼品、礼金、有价证券和支付凭证；严禁参与各种形式的赌博活动，特别是以赌博形式收受财物。三是要严肃查处各种违纪违法行为。镇纪委要畅通群众举报渠道，强化监督检查，严肃查处党员领导干部违反《廉洁准则》的行为。对党员干部节日期间擅离职守、失职渎职、顶风违纪的，发现一起，查处一起，严肃追究直接责任人和有关领导的责任，并对典型案例予以通报曝光，切实巩固改进作风的成果。</p>
', 1, 1, 14, 4, 1, 1, 1, 0, 1, CAST(0x0000A20300B9DEA4 AS DateTime), 1, CAST(0x0000A23B01128CDA AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, 0, N'梁寨镇2010年上半年工作总结暨下半年工作计划', N'<p>
 <strong><font face="宋体">2010年上半年，我镇围绕县委、县政府的中心工作，深入学习践行科学发展观，围绕年初所定的目标，狠抓招商引资和项目建设，集中力量改善农村的基础设施条件，促进了全镇社会各项事业的协调发展。现将2010年上半年工作总结和下半年年工作计划报告如下：</font></strong></p>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp;&nbsp; 主要目标完成情况</font></b></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 截至5月底，我镇累计完成财政总收入2492万元，完成全年任务的49.2%，其中国税完成748万元，完成全年任务的34%，地税完成1689万元，完成全年任务的58.9%。一般预算收入完成1729万元，完成全年任务的57.3%。计划生育政策符合率达90%，上半年农村人均纯收入超过5000元，半年人均增收2000元；累计农村劳动力转移23000人。<br />
 <b>&nbsp;&nbsp;&nbsp; 一、凝聚动力、夯实基础抓党建</b></font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 我镇以机关效能建设年为契机，成立了以书记任组长的镇干部作风建设年活动领导小组，精心制定工作方案，及时召开全镇干部动员大会，迅速在全镇掀起干部作风建设年活动的热潮。五月份，我镇又召开了&ldquo;党员、干部&lsquo;廉政准则&rsquo;宣传教育专题报告会&rdquo;，严格落实省、市、县有关规定和要求，结合《〈中国共产党党员领导干部廉洁从政若干准则〉学习读本》，及时、足额发放粮食直补、农机具购补和家电下乡产品补贴，公开透明的开展了新农保、低保的参保工作，使公开率达100％，满意率达99％。杜绝了白条帐、人情帐、关系帐。增强了干部的责任意识、大局意识、服务意识、纪律意识，加强了机关效能建设。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 按照县委组织部&ldquo;阵地建起来、喇叭响起来、红旗飘起来&rdquo;之要求，我镇凝聚力量、夯实强化了农村基层党组织建设。按照换届选举的程序规定，认真在新阎楼、孟楼等村开展了换届选举工作。以配齐配强村党支部书记为主线，将村中的经济能人、致富能手、企业老板以及有威望、能干事的优秀人才选到村 &ldquo;两委&rdquo;班子中来。截止到5月底，共发展党员20名，培养积极分子61名。全面完成了全镇20个行政村的村级活动场所建设。<br />
 <b>&nbsp;&nbsp;&nbsp; 二、全民动员、资源共享促招商</b><br />
 &nbsp;&nbsp;&nbsp; 今年以来，镇党委政府围绕&ldquo;亿元项目再突破&rdquo;目标，继续把加招商引资作为主要任务，全民动员、信息联动大力开展招商活动，推进项目建设进位次、上水平，上半年经洽谈落地1000万元以上的项目共18个：</font></font></strong></div>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp;&nbsp;（一）已签约正建设项目：</font></b></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;1、深圳宏宝源木制品有限公司总投资5000万元兴建的占地57亩的项目6月底可建成投产；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;2、由山东客商投资1000万元的纺织厂即将配齐机器，预计8月份建成投产；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;3、由浙江客商投资2000万元的万头养猪场进展顺利；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;4、投资500万元的苏宁电器梁寨店已开业。</font></font></strong></div>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp; （二）已签约正在办理投资手续的项目</font></b></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、香港客商投资400万港币的宾馆饭店项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、山东客商投资2000万元，占地20亩的年屠宰1000万只肉鸭项目。</font></font></strong></div>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp; （三）正在洽谈的项目（8个，其中超亿元项目2个）</font></b></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、常州天合光伏产业园投资5亿元的太阳能发电项目，客商多次来丰县考察，形成投资意向，正在做项目预可研；&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、由天津宝迪公司投资2.1亿元的年生产5万头生态种猪厂项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、浙江绍兴客商投资3000万元的纺纱织布项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4、苏州客商投资2000万元的洗煤项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 5、福建客商投资5000万元的万吨冷库及蔬菜加工项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 6、高超投资1500万元的大蒜粉加工项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 7、孙祖华投资500万元的冷库项目；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 8、家具客商城项目。</font></font></strong></div>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp; （四）、续建项目4个：</font></b></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、投资16亿元的丰成盐化工项目，进展很快，联碱部分年底可建成投产；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、徐州天禾食品改建项目，已完成投资300万元；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、徐州润新电力配件项目已完成投资300万元；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4、深圳森威达公司投资4500万元工业养羊项目。</font></font></strong></div>
<div>
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp;&nbsp;（五）、利用外资项目3个：</font></b></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、由香港客商投资400万港币，注册300万港币（折合美元50万元）的徐州宁伟休闲度假有限公司，已完成营业执照、代码证办理，外资账户已开好，正在办理税务登记证，预计外资6月份可到位；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、金色韩国株式会社投资食品加工项目，正在洽谈；</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、正在办理的自营出口企业徐州盛大绿色食品有限公司。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><b><font face="宋体">&nbsp;&nbsp; 三、以民为根惠农民</font></b></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp; 1．农田改造工程。开挖北支河8.3公里，开挖土方40万立方米。认真抓好村庄环境整治及坑塘治理工作，在4个行政村实施。共开挖中沟6条，小沟19条，大坑8处，土方18万方。新打深机井6眼，配备变压器12台。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp; 2.富农惠农工程。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp; （1）落实粮食综合补贴共 486.64万元，水稻补贴8.4万元，受益农户15800户。办理家电下乡产品补贴3463台件，补贴资金70.04万元。汽车、摩托车下乡补贴535辆，补贴资金90.27万元。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp; （2）全镇已参与新农保2.5万人，收缴保费近200万元，完成任务的120％。享受低保待遇3200人，目前已进入公示阶段。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3.动物防疫工程。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp; 今春，我镇对全镇5万只家禽进行了口蹄病、蓝耳病、猪瘟等疫病的免疫，对500万羽家禽进行了高致病性禽流感、新城疫等重大疫病的防疫，防疫密度达到90％以上。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4.安全饮水工程：我镇是饮水高氟地区，年初以来,党委政府抢抓水利项目机遇，加大工作力度，抓紧落实，新打深水机井6眼，铺设主干道17.8公里，入户3200户。加大供水管网改造，实现了全镇范围供水管网联网。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 5.道路建设工程。积极实施农村公路、生产路畅通工程，今年上半年共埋设过路涵8处。完成了1400米的振兴路两侧花池的改建及新建的定点放线工作、安居路至河滨路250米长的下水道定点放线工作和文化路600余米水泥路面的铺设工作。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 6.新农村建设：镇党委政府切实维护群众利益，积极克服各种困难，千方百计筹措、运作资金，保证全镇的城乡建设用地增减挂钩工作有序、快速推进，目前全镇增减挂钩设计的5个自然村、281户补偿测算已完成，房屋拆迁全面实施。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 7.特色农业产业。全镇种植（大）苔蒜4.5万亩，形成了孟楼、小王楼、新集、小李寨、辛庄、杨新庄、黄楼7个苔蒜种植专业村，建有孟楼亿元级中国苔蒜市场和中国苔蒜网。夏番茄面积7000亩，形成了孟楼、小王楼、石桥等3个夏番茄专业村。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 徐州马兰农业发展有限公司建成高标准日光温室91个，设施大棚600亩，建成了江苏省最大的有机食品生产基地，幅射带动了梁满路两侧3000亩设施农业发展，形成了梁寨、赵楼、石桥、盖庄、举人庄5个设施农业专业村。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 截止5月底，全镇100头以上养猪户已达56户，生猪饲养量达到1.2万头。全镇蛋鸡饲养110户，种鸭栏存量突破10万只，肉鸭出栏量500万羽，纯种波尔山羊突破500只，全镇出栏肉羊4万只。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">通过招商引资，江苏省恒锦畜牧业有限公司已落户该镇，将建成全省最大的肉羊育肥场。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 8.小城镇建设：</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 投资60万元的通往渊子湖的大桥已签约，将于今年10月竣工，该桥的建成，为我镇旅游业建设拓展打下了坚实基础。完成北支河8.3公里的河道绿化，植树11万株。完成振兴街高标准绿化，栽植花卉苗木2万多株。启动了农贸市场改造工程，完成了临时过渡摊位的建设。硬化场镇路面50000平方米，人行道改造3600余平方米。更换场镇垃圾桶26个，新安装场镇路灯200盏，补植行道树2000余棵，改善了场镇环境面貌。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 四、社会事业全面发展</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、人口与计划生育工作全面落实。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">我镇党政一把手亲自抓计划生育工作，以宣传教育为主，全面开展了计划生育专项执法清理，效果较好。上半年共有隐患1953人，已落实隐患1112人，其中已上环273人，县站引流产48人，隐患治理和四项措施落实位居全县第三名。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、民政工作有序开展。</font></font></strong></div>
<div align="left">
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 我镇确保程序透明及时准确地完成了全镇3200人低保的申报、公示及上报工作，按时完成了农合作医疗和新农保的普及任务，全镇农合参保率达98%，新农保已完成120%。总投资200多万元的玲兴敬老院建设已全部完成。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3.综合治理和安全监管工作全面加强。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 我镇联合派出所、工商、文广站等部门对网吧、游戏厅、音响制品等开展了专项整治活动，使人民群众的安全感得到增强，社会秩序得以进一步好转。全面落实信访工作责任制，排查解决了信访突出问题11 件。安全生产工作做到人员、经费、责任三落实，按照&ldquo;横向到边，纵向到底&rdquo;的工作原则，加大了节假日和日常安全生产的检查监管力度，实现了安全生产事故、死亡事故为&ldquo;零&rdquo;的目标。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4.教育卫生事业蓬勃发展</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 我镇中心医院投资38万元规范了急诊区的建设，投资6万元新建职工餐厅和病人餐厅，门诊楼500平方的装饰工程和病房综合楼正在施工。两所医院就诊、转诊、住院报销更加规范，基础设施和医疗设备逐步完善。中学、初中和各小学均能做到&ldquo;以人为本、以德育人抓常规&rdquo;&ldquo;因材施教、提优补差促中间&rdquo;，梁寨中学经过充分论证，将于今冬明春完成三星级高中的验收，初级中学的升学率连年攀升，中心小学的乒乓球教学已小有特色。高、初、小三级学校已联手打造人才培养计划，争取在3&mdash;5年内打造出全县知名的高校人才培养基地。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp; 5.服务业初显成效</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 目前全镇共有服务业企业12家，全镇服务业个体工商户139家，其中苏宁电器店为苏北乡镇第一店，开业当天营业额达近百万元。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 两个信用社以服务&ldquo;三农&rdquo;为宗旨，内外结合，存贷挂钩，以贷引存，做好临柜服务和上门服务。年初以来，累计发放贷款2500万元，重点扶持了一批种养殖专业户，培养了两家农业龙头企业，推动了我镇农村经济的发展。</font></font></strong></div>
<div align="center">
 <strong><font face="宋体"><font face="宋体"><strong>下半年的工作计划</strong></font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2010年下半年，我镇在县委、县政府的正确领导下，克服困难，细化措施，真抓实干，确保完成县委、县政府下达的各项目标任务。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 一、落实措施，全面完成招商引资及财税工作。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 围绕增强发展后劲，强化产业链招商，抓好重点区域招商，特别特别是要做好驻外招商引资工作。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、加快在建重点项目，加快推进新型工业化。继续做好丰城盐化工跟踪服务工作，确保今年10月份正式生产；全面完成徐州天禾食品有限公司的扩建工作，力争建设规模达到年产1万吨水果蔬菜罐头，成为丰县最大的罐头加工企业，2010年达到省级企业标准；加快福建客商投资6亿元的120万吨焦炭项目洽谈进度，力争尽快签约；加快徐州马兰农业发展有限公司新扩建600亩设施农业基地建设进度，确保元月份建成并投入使用；加快江苏省恒锦畜牧业发展有限公司进度，确保下半年投入使用。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、加快重点项目常州光伏太阳能发电项目的洽谈，力争尽快签约。加快深圳宏宝源木制品有限公司总投资5000万元兴建的占地57亩的项目进度，力争尽快投产。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、强化税收征管。继续加大财源建设力度，克服重重困难，积极培植财源，夯实财政增收基础。坚持依法治税，强化征管措施，确保按照序时进度均衡入库，完成县委县政府下达给我镇的财税征收任务。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 二、突出强农富民，积极推进农业产业化。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 以农业增效，农民增收，农村稳定为核心，以徐州马兰农业发展公司为龙头，辐射带动全镇发展3000亩设施农业发展，不断增加农民收入。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、继续调优农业结构。大力发展现代农业，以梁寨村、盖庄村为依托，发展优质蔬菜和瓜果3000亩，全面完成徐州马兰公司1000亩设施农业的扩建工作，建设高标现代化农业生产基地，不断提高农业效益，增加农民收入。积极探索土地流转机制，鼓励和引导土地向种植大户和专业能人集中，逐步培育规模种植，建立多种形式的专业合作社。养殖业将继续改良品种，扩大规模饲养。继续稳定生猪生产、巩固肉鸭生产、突出发展肉牛产业，发展肉羊特色产业，20只养羊大户达到600户，全年饲养量达到20万只，肉鸭养殖专业村10个，肉鸭饲养量达到1000万羽。努力创建全县肉羊生产第一镇，肉鸭生产第一镇，肉牛生产全县第一镇。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、继续加强农村基础建设。不断改善村级办公条件，强化村级阵地建设。继续加强农田水利建设、农村土地复垦和综合治理工作，提高农业的综合利用效益，全面完成全镇17个行政村的改水任务。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、继续做好新农村建设工程。全面完成黄楼和小李寨村的新农村建设任务，不断改善农民的生产和居住环境。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4、继续做好农民培训和劳动力转移工作。加强对农民的培训力度，提高农民素质，促进农民就业；积极探索劳务输出的新途径，加快农村剩余劳动力的转移。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 三、突出城镇建设和旅游开发，打造精品小城镇。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、完善集镇规划修编，强化集镇功能。加大中心镇建设力度，进一步完善集镇美化、亮化、硬化工程，加强镇区管理，规范集镇管理，提高城镇化水平。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、以梁寨渊子湖为依托，以市场为导向，加快旅游开发。抓住省水利开发梁寨渊子湖建设机遇，做活渊子湖开发文章。充分利用资源优势，全方位包装休闲旅游、农家乐等项目，积极向外推介，以招商引资、群众自筹等方式进行开发，不断发展壮大旅游产业，并带动相关产业的发展，使之成为新的经济增长点。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 四、加快构建和谐社会，确保各项社会事业协调发展。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、加强社会主义民主法制和精神文明建设。抓好村干部的学习培训，不断提高带领群众致富的本领。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、做好信访稳定工作和农村稳定工作。高度重视信访工作，进一步落实信访稳定工作责任制，建立健全应急预警机制、矛盾纠纷疏导化解机制和处置工作体系，及时排查各类不稳定因素。深化&ldquo;平安梁寨&rdquo;建设、&ldquo;和谐梁寨&rdquo; 创建活动。加强社会治安综合治理，严厉打击刑事犯罪活动治安违法活动。确保社会大局稳定。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 3、切实抓好</font><a href="http://www.gwgx.com/"><font face="宋体">计划</font></a><font face="宋体">生育工作，稳定低生育水平。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 4、协调各项社会事业发展。大力发展科教事业，巩固&ldquo;两基&rdquo;成果。完成梁寨中学三星级高中的验收；加强农村医疗卫生工作，健全农村医疗卫生网络，不断提高人民群众医疗卫生保健水平；努力健全体育、文化娱乐设施，加强村级文化建设，开展丰富多彩的群众性文化活动。切实抓好救灾救济、农村低保工作和农村大病救助工作，促进社会福利事业和保险工作的顺利发展。全面完成全镇5个村的村部建设任务。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 五、突出依法行政，建设廉洁、高效、服务型政府。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 1、坚持以人为本，改善机关办公、生活条件。维护好、发展好、服务好人民群众的根本利益，认真贯彻落实县委、县政府&ldquo;双治双促&rdquo;活动精神，强化执政为民的意识，切实抓好政府自身建设，打造廉洁、高效、服务型政府。</font></font></strong></div>
<div>
 <strong><font face="宋体"><font face="宋体">&nbsp;&nbsp;&nbsp; 2、加强干部队伍建设，不断提高工作效率和服务水平。严格考核管理机制，大力加强镇村干部日常考核和实绩考核。进一步改善干部工作作风和学风。</font></font></strong></div>
', 1, 1, 0, 4, 1, 1, 1, 0, 1, CAST(0x0000A20300BBB10D AS DateTime), 1, CAST(0x0000A23B0110385E AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (7, 0, N'梁寨镇“蒜茬”番茄“红”了菜农日子', N'<p align="left">
 <font size="3"><strong>&nbsp;盛夏时节，中国苔蒜之乡&mdash;&mdash;梁寨镇种植的5000亩&ldquo;蒜茬&rdquo;西红柿也进入了采摘旺季，售出的苔蒜刚刚让老百姓赚个盆满钵丰的时候，该镇由蒜农转为的菜农又忙着喜摘番茄、忙装车子、笑换票子。</strong></font></p>
<div align="center">
 <font size="3"><strong><img border="0" src="http://www.chinafx.gov.cn/editor/UploadFile/2010-7/29/2010729212436332.jpg" /></strong></font></div>
<div>
 <font size="3"><strong><font face="宋体">　　该镇种植的西红柿色泽鲜艳、沙瓤甘甜，刚一上市就卖到1元/公斤，按亩产近万斤来算，平均亩收入3000&mdash;&mdash;6000元。加上春季蒜薹和苔蒜的收入，该镇老百姓个个露出笑脸，家家一派丰收。</font></strong></font></div>
<div>
 <font size="3"><strong><font face="宋体">&nbsp;&nbsp;&nbsp; &ldquo;蒜茬&rdquo;西红柿之所以能赚钱，在于他们&ldquo;茬口&rdquo;选择的好。反季节蔬菜诚然会价格高，市场好，但顺季节蔬菜却有着价格稳定的绝对优势，加上&ldquo;蒜茬菜，菜茬蒜&rdquo;的种植模式，已让该镇农民从&ldquo;靠天吃饭&rdquo;到&ldquo;旱涝保收&rdquo;。</font></strong></font></div>
<div>
 <font size="3"><strong><font face="宋体">　　近年来，该镇不断调整产业结构，引导农民种植优质特色蔬菜，按照&ldquo;打造全省苔蒜第一镇&rdquo;的发展模式，通过&ldquo;走进田，上去网，请进商，卖出菜&rdquo;的办法，努力培育科学种植技术，种植了一批在省内外市场上&ldquo;吃得香、叫得响&rdquo;的名特优良种，使早中晚熟品种合理搭配，均衡上市。(</font></strong></font></div>
', 1, 1, 0, 4, 1, 1, 1, 2, 1, CAST(0x0000A20E00FECD2E AS DateTime), 1, CAST(0x0000A23B011AD3A7 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (8, 0, N'梁寨镇两景点初迎八方客', N'<div>
	<font face="宋体">适逢清明三天短假，梨花盛开。丰县城南车水马龙、游人如织。人们漫步果海，亲近自然、赏花踏青。作为大沙河的临镇，4月5日，梁寨镇区渊子湖和状元碑两处景点初次迎来周边县城客人，让当地的群众初步看到了蕴含的商机。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 状元碑园因珍藏清康熙徐州状元李蟠撰作书丹的碑铭而得名，座落于该镇黄楼村，为仿清古代建筑，庄重典雅、精致堂皇，造型优美，是一处内涵丰富的历史文化景点。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 渊子又叫淹子，面积约1.5平方公里，地处该镇红楼村，与安徽省萧县毗邻。湖水常年清澈，芦苇荡漾、花团锦簇、荷花飘香，藕芽萌动、荷枝竞长。荷田内舟楫畅行，水清荷碧，可谓追求安逸恬适最佳去处。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 近年来，该镇党委政府除把特种种植、养殖作为一项支柱产业来抓之外，还充分利用当地的自然资源加大了开发旅游业的热情和力度。今年，该镇以丰县第11届梨花节为契机，早准备、早策划、早宣传，启动了&ldquo;梨花效应战略&rdquo;，使该镇旅游业有了突破性的进展。</font></div>
', 1, 1, 0, 4, 1, 1, 1, 3, 1, CAST(0x0000A20E00FED830 AS DateTime), 1, CAST(0x0000A23B011BB515 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (9, 0, N'梁寨镇农民喜把蒜苗“捆成钱”', N'<div>
	<font face="宋体">日前，梁寨镇蒜苗喜获丰收，陆续上市。全国各地蔬菜商贩通过该镇开通的&ldquo;中国薹蒜网&rdquo;得到信息，纷纷从四面八方慕名而来、争相抢购，从而使一捆捆&ldquo;秀色可餐&rdquo;的蒜苗变成大把大把的钞票，装在农民口袋里，乐在农民心坎里。</font><br />
	&nbsp;</div>
<div align="center">
	<img border="0" src="http://www.chinafx.gov.cn/editor/UploadFile/2010-3/24/2010324132533956.jpg" /><br />
	&nbsp;</div>
<div>
	<font face="宋体">&nbsp;&nbsp; &nbsp;蒜苗含有蛋白质、胡萝卜素、硫胺素、核黄素等营养成分。所含的辣素具有醒脾气、消积食、杀菌、抑菌作用，能有效预防流感、肠炎等因环境污染引起的疾病。蒜苗还对于心脑血管有一定的保护作用，可预防血栓的形成，同时还能保护肝脏，诱导肝细胞脱毒酶的活性，可以阻断亚硝胺致癌物质的合成，对预防癌症有一定的作用。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 据悉，上市初期，每公斤批发价卖到3.0元至4元，中后期能买到1&mdash;2元∕公斤，一般亩产3000斤，也就是说亩产均值达到4000元左右。</font><br />
	&nbsp;</div>
<div align="center">
	<font face="宋体"><img border="0" src="http://www.chinafx.gov.cn/editor/UploadFile/2010-3/24/2010324132238124.jpg" /></font><br />
	&nbsp;</div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 孟楼村一蒜农从收购商手中接过一沓钞票说：&ldquo;一开春就收入几千块钱，是个好兆头，今年一定能过上好日子！&rdquo;</font></div>
', 1, 1, 0, 4, 1, 1, 1, 2, 1, CAST(0x0000A20E01682E39 AS DateTime), 1, CAST(0x0000A23B011BF56A AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (10, 0, N'“名花有主”——丰县第一家金银花专业合作社落户梁寨', N'<div>
	<font face="宋体">2010年2月8日，丰县第一家金银花合作社&mdash;&mdash;丰县佳强绿色农业合作社在梁寨镇挂牌成立。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 金银花，又名金花、银花、双花、忍冬花，是国务院确定的名贵中药材之一。&ldquo;金银花浑身宝，防疫治病离不了&rdquo;，由此可见，金银花其医药保健功能、经济价值都很高，丞待开发和利用。除供药用外，还能用于保持水土，改良土壤，调节气候，它生长泼辣，适应性非常广泛，无论山区、平原、粘壤、沙土、微酸、偏碱地区都能生长，随着人们食物构成的改变和生活水平的提高，金银花的用途越来越广，开始由药用转向食品、饮料和日用化工等方面发展。 </font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 梁寨镇地处丰县东南边陲，在引导村民调整产业结构中，该镇立足村情，顺乎民意，目前已在梁满路两侧发展设施农业近千亩，区位优势非常明显，气候和土壤较适合金银花生长。经多方考证后，2010年2月，该镇与金乡县佳强农贸有限公司联姻达成了合作协议，成立了丰县首家金银花合作社，形成了公司加农户加基地的发展模式。并聘请河南省农科院粮作所科技有限公司作为常年技术顾问，计划首期培植苗圃50亩，最终发展为500亩种植基地。</font></div>
<div>
	<font face="宋体">&nbsp;&nbsp;&nbsp; 预计，一年后，金银花将成为该镇农民除苔蒜、大棚蔬菜之后的第三大经济收入的来源，该镇镇长巩志刚这样描述金银花的未来：&ldquo;金银花开金银来&rdquo;&ldquo;栽培金银花，利国又发家&rdquo;。</font></div>
', 1, 1, 0, 4, 1, 1, 1, 2, 1, CAST(0x0000A20E0168483E AS DateTime), 1, CAST(0x0000A23B011C2385 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (11, 0, N'丰县梁寨镇人民政府政府领导分工', N'<p align="left">
 <font face="宋体"><font face="Verdana"><font face="Verdana"><font face="Verdana">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 王&nbsp; 磊：党委书记。负责党委全面工作，侧重工业、农业。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 范海宁：党委副书记、镇长。负责政府全面工作，侧重财贸、城建。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 王世珍:&nbsp;人大主席。负责人大工作，分管农业、新农村建设、脱贫攻坚、重大动物防疫、计划生</font><font face="Verdana">育、卫生、农村道路建设、小康建设<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 李新勇：党委副书记。分管组织、宣传、统战、民族宗教、党政办公室、老龄委、关工委、青年</font><font face="Verdana">、妇联、工会、目标责任量化考核、教育、精神文明建设、文化产业、行政效能、政法、民政、</font><font face="Verdana">信访，协调政法、信访。联络邮政、电信。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 李敏杰：纪委书记、武装部长。负责纪检、武装，工业经济、投资和项目建设、招商引资、现代</font><font face="Verdana">服务业、开放型经济、安全生产、统计、工交、环保、联络供电，协调科技、商务部门。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 李若峰：组织委员。主管党建、基层组织建设、干部工作、老干部工作、量化考核、老龄委、关</font><font face="Verdana">工委、水利、开发、一村一品、劳动保障，四有一责。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;李&nbsp;&nbsp; </font></font></font></font><font face="宋体"><font face="Verdana"><font face="Verdana"><font face="Verdana">芳：宣传委员。主管宣传、教育、信息网站、中国苔蒜网、广播文化、党政办公室、行政效能</font><font face="Verdana">、文化产业、精神文明创建。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 刘&nbsp;&nbsp; 峰：党委委员、副镇长。主管财税、财政、审计、粮食、供销、劳务输出、项目工程，联络</font><font face="Verdana">国税、地税、工商、物价、信用社。&nbsp;<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 王 &nbsp; 峰：政法委员。主管政法、民政、信访、老龄委、关工委、安全生产。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 刘成宏：副镇长。主管城建工作、城管、市场建设。分管土地、规划、建设、建管、城建、环境</font><font face="Verdana">整治，市场建设、城镇管理，协调城管。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 季明庚：副镇长。主管农技中心、农经中心、畜牧中心、脱贫攻坚、重大动物防疫，四有一责、</font><font face="Verdana">农村道路建设，联络交通。<br />
 &nbsp;&nbsp;&nbsp;&nbsp; 周长英：副镇长。主管工业、招商引资、科技创新、民营经济、三外、生态镇创建，联络供电。<br />
 &nbsp;&nbsp;&nbsp;&nbsp; 高&nbsp;&nbsp; 建：实业公司副总经理。主管计划生育、卫生防疫、农村改厕、食品药品安全、环保工作。</font></font></font></font></p>
', 1, 1, 0, 4, 1, 1, 1, 0, 1, CAST(0x0000A23B01144F66 AS DateTime), 1, CAST(0x0000A23C00D48E62 AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (12, 0, N'“新农民”用上“新技术”', N'<p>
 <strong><font size="3"><font size="3">&nbsp;&nbsp;我们梁寨镇盖庄村从远程教育站点学到了大棚蔬菜种植和病虫害预防技术，不断加强大棚蔬菜田间管理，今年入秋以来我村的30亩大棚蔬菜卖了20多万元，每个棚比上年多收入了3000多元。梁寨镇盖庄村负责人陈德平高兴地说。&nbsp;该镇像盖庄村村民一样通过远程教育掌握新技术的新农民不在少数。近年来，梁寨镇因势利导，充分发挥远程教育&ldquo;传帮带&rdquo;作用，根据农民需求，专门制定了远程教育播放计划，发动农民准时去村远教室收看。大棚蔬菜种植宜忌、如何提高蔬菜种植的产量和品质、病虫害如何防治、小麦玉米等农作物的栽培与管理等农民渴望学到的知识，只要轻轻一点鼠标，各项技术讲座便展现在眼前。如今，通过远教网络&ldquo;选良种、学农技、查信息&rdquo;已成为梁寨镇农民的新时尚。</font></font></strong></p>
', 1, 1, 0, 4, 1, 1, 1, 7, 1, CAST(0x0000A23B0118C7DC AS DateTime), 1, CAST(0x0000A23B0118C7DC AS DateTime))
INSERT [dbo].[webfarmingnews] ([AutoID], [CustomerID], [Title], [Content], [Opertype], [Status], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [VillageID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (13, 0, N'梁寨镇“土项目”鼓起农民钱袋', N'<p>
 <font size="3">9月6日，丰县梁寨镇孟楼村农民马德海正在自家的钢架大棚里组织人们进行翻整菌包。去年8月，马德海投资3.5万元，在自己的钢构大棚里，当年上了10万个菌包，纯收入达5万多元。今年他又上了20万个菌包，&ldquo;预计纯收入可达10万元。&rdquo;马德海说。距孟楼村支部对面的李志物流贸易中心，村民们正开动4台栽培料搅拌机，将玉米芯、棉籽壳和麸皮、白灰等混在一起，生产菇菌包栽培料，每台机用劳工10人，一天一台机可生产4000-5000个菌包。<br />
 　&nbsp; 为推动农民增收致富，丰县梁寨镇近年探索出的一条行之有效的富民之路，利用玉米芯、棉籽壳生产平菇的&ldquo;土项目&rdquo;。该镇利用孟楼市场，制定优惠政策，先后投资建成钢构大棚144个，这些大棚上半年作为大薹蒜的收购点，下半年作为平菇生产基地，仅去年生产优质平菇2250吨，实现产值2000多万元，单棚平均效益在4万元以上，吸纳1000多名农民就业。带动就业3000余人，人均年增收1000元。</font></p>
', 1, 1, 0, 4, 1, 1, 1, 8, 1, CAST(0x0000A23B011A5229 AS DateTime), 1, CAST(0x0000A23B011A5229 AS DateTime))
SET IDENTITY_INSERT [dbo].[webfarmingnews] OFF
/****** Object:  Table [dbo].[webbeautifulvillageFile]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[webbeautifulvillageFile](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TownID] [int] NOT NULL,
	[VillageID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[FileType] [varchar](1) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[FileUrl] [varchar](2000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[FileSUrl] [varchar](2000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[LinkUrl] [varchar](2000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[FileRmark] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OrderValue] [int] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__webbeaut__6B23296561316BF4] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'魅力乡村自增长ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'魅力乡村标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'TownID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡镇ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'TownID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'VillageID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡村ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'VillageID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'FileType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 文件类型,0:图片，1：视频' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'FileType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'FileUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文件存放路径' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'FileUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'FileSUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文件缩略图存放路径' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'FileSUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'FileRmark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文件描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'FileRmark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillageFile', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillageFile', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[webbeautifulvillageFile] ON
INSERT [dbo].[webbeautifulvillageFile] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [FileType], [FileUrl], [FileSUrl], [LinkUrl], [FileRmark], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'梁寨之门', 0, 1, 2, 1, N'', N'upload/0/2013/8/24/20130824223139318.jpg', N'upload/0/2013/8/24/20130824223139318_s.jpg', N'', N'', 888, 1, CAST(0x0000A22401733E3C AS DateTime), 1, CAST(0x0000A2280165A94F AS DateTime))
INSERT [dbo].[webbeautifulvillageFile] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [FileType], [FileUrl], [FileSUrl], [LinkUrl], [FileRmark], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'梁寨镇中心（1）', 0, 1, 2, 1, N'', N'upload/0/2013/8/24/20130824223833532.jpg', N'upload/0/2013/8/24/20130824223833532_s.jpg', N'', N'', 887, 1, CAST(0x0000A224017523AC AS DateTime), 1, CAST(0x0000A2280165BE4A AS DateTime))
INSERT [dbo].[webbeautifulvillageFile] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [FileType], [FileUrl], [FileSUrl], [LinkUrl], [FileRmark], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'梁寨镇中心（2）', 0, 1, 2, 1, N'', N'upload/0/2013/8/25/20130825151314068.jpg', N'upload/0/2013/8/25/20130825151314068_s.jpg', N'', N'', 886, 1, CAST(0x0000A22500FAD3C9 AS DateTime), 1, CAST(0x0000A2280165C9D0 AS DateTime))
INSERT [dbo].[webbeautifulvillageFile] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [FileType], [FileUrl], [FileSUrl], [LinkUrl], [FileRmark], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'梁寨渊子湖', 0, 1, 2, 1, N'', N'upload/0/2013/8/25/20130825152130175.jpg', N'upload/0/2013/8/25/20130825152130175_s.jpg', N'', N'', 885, 1, CAST(0x0000A22500FD192D AS DateTime), 1, CAST(0x0000A2280165D28F AS DateTime))
INSERT [dbo].[webbeautifulvillageFile] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [FileType], [FileUrl], [FileSUrl], [LinkUrl], [FileRmark], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'梁寨街道', 0, 1, 2, 1, N'', N'upload/0/2013/8/28/20130828214405040.jpg', N'upload/0/2013/8/28/20130828214405040_s.jpg', N'', N'', 886, 1, CAST(0x0000A22801662D67 AS DateTime), 1, CAST(0x0000A22801664729 AS DateTime))
SET IDENTITY_INSERT [dbo].[webbeautifulvillageFile] OFF
/****** Object:  Table [dbo].[webbeautifulvillage]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[webbeautifulvillage](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TownID] [int] NOT NULL,
	[VillageID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Intro] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Yield] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Live] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Environment] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Humanism] [ntext] COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OrderValue] [int] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__beautifu__6B23296500DF2177] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'魅力乡村自增长ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'魅力乡村标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'TownID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡镇ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'TownID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'VillageID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡村ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'VillageID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Intro'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'村庄介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Intro'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Yield'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生产美' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Yield'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Live'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生活美' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Live'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Environment'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'环境美' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Environment'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Humanism'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人文美' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Humanism'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'webbeautifulvillage', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'webbeautifulvillage', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[webbeautifulvillage] ON
INSERT [dbo].[webbeautifulvillage] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [Intro], [Yield], [Live], [Environment], [Humanism], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'魅力梁寨村', 0, 1, 2, 1, N'<p>
 &nbsp;&nbsp; 韭园村位于王平镇政府东部，村域面积 3.9平方公里，海拔180米。&ldquo;百花争艳春耕忙，艳阳高照夏风光，硕果累累秋景爽，蓝天白云冬气象&rdquo;，在这个&ldquo;天然大氧吧&rdquo;的优美村庄中居住着223户人家。2009年人均纯收入达到8000元。<br />
 &nbsp;&nbsp;&nbsp; 2007年度分别被评为首都文明村、北京市村务公开民主管理示范村、村庄建设先进村、首都绿色村庄称号；<br />
 &nbsp;&nbsp;&nbsp; 2008年度分别被评为环境整治先进单位、农民致富先进村、敬老模范村委会称号；<br />
 &nbsp;&nbsp;&nbsp; 2009年分别荣获北京最美乡村提名、先进党支部、村委会、北京市门头沟区森林防火工作先进集体、农民致富先进村称号；<br />
 &nbsp;&nbsp;&nbsp; 2010年2月分别荣获2009年度新农村建设先进单位、2009年度生产发展先新村称号。&nbsp;</p>
', N'<p>
 三季有花，四季有果，韭园村定会让您高兴而来，满意而归。<br />
 &nbsp;&nbsp;&nbsp; 色红味浓的香椿、味美玲珑的樱桃，五六十年代就成为国宴贡品的京白梨、酸甜可口的大杏、四季长流的清泉，使人倍感清新。<br />
 &nbsp;&nbsp;&nbsp; 春天的韭园是山花烂漫，蕴藏着勃勃生机；夏天的韭园是江南美景闺中藏，青翠欲滴。<br />
 &nbsp;&nbsp;&nbsp; 1、韭园村种植樱桃的历史悠久。韭园村栽种的甜樱桃在2004年、2005年两年参加北京市樱桃评比时都获得了优胜奖。这里的樱桃园被评为市级标准化观光采摘园。<br />
 &nbsp;&nbsp;&nbsp; 2、韭园村出产的京白梨在60年代名扬京城，在60年代计划经济时期北京市果品公司把韭园的京白梨送上了国宴，成为国宴专用水果。京白梨有特定的栽培环境要求，管理技术要求比较高。它的特点是皮薄、肉细、汁多、味甜和果核小。<br />
 &nbsp;&nbsp;&nbsp; 3、韭园村有一种时髦的野果，就是在手里耍玩的麻核桃。它是核桃中的一个变种，是由野核桃和家核桃自然杂交形成的一个稀有树种。<br />
 &nbsp;&nbsp;&nbsp; &ldquo;百花争艳春耕忙，艳阳高照夏风光，硕果累累秋景爽，蓝天白云冬气象。&rdquo;</p>
', N'<p>
 &nbsp;&nbsp;&nbsp; 古朴整洁的韭园村有着老北京那雕梁画柱的老宅院、现代都市型的柏油马路迎接着每位游客的到来，路边的潺潺小溪，淙淙泉水留住你的脚步。走在村里的小巷中，会看到点点民居分布。煞那间你会觉得幽静与清新，坐在树阴下顿感神清气爽。<br />
 &nbsp;&nbsp;&nbsp; 我村经过科学的管理，得到了上级领导部门的认可。普及科普知识提高了居民健康水平、优化了环境，为我们今后的发展奠定了基础，同时也丰富了村民的文化，增强了村民的管理水平，为我村今后的发展增添了光彩。<br />
 &nbsp;&nbsp; &nbsp;1、韭园村示范基地&mdash;&mdash;韭园村老年活动站具有完善的基础、娱乐、健身等设施，有利于我村村民的娱乐、健身等活动。<br />
 &nbsp;&nbsp; &nbsp;2、具有相应的科普工作机构，配备了专职管理人员及完善的管理制度。公共场所有了安全稳定的祥和环境。<br />
 &nbsp;&nbsp; &nbsp;3、开展农业种植知识的讲座，实用技术培训（京白梨、樱桃的种植技术）。为百姓在农业技术上有了很大提高，果品产量有大幅度提升。<br />
 &nbsp;&nbsp; &nbsp;4、积极利用文字宣传手段做好农业、健康、优化环境等方面的知识宣传。使之有了妥善的开展功效。<br />
 &nbsp;</p>
', N'<p>
 &nbsp;&nbsp;&nbsp;&nbsp;1、这里有刘、关、张，象征忠义的三义庙，名传千古，世人仰慕。<br />
 &nbsp;&nbsp; &nbsp;2、自然景观、人文景观于一体的著名天然韭园溶洞。<br />
 &nbsp;&nbsp;&nbsp; 3、古代军事遗迹碉楼，共三层，方孔用于通风、透光、是金国时期站岗放哨的设施。<br />
 &nbsp;&nbsp;&nbsp; 4、山桃花竞相开放，是人们向往自然，追求健康旅游的胜地。<br />
 &nbsp;&nbsp;&nbsp; 5、上演春秋战国的历史故事。<br />
 &nbsp;&nbsp;&nbsp; 6、千年古道，流淌着古道西风瘦马的畅想，古道悠悠担起大漠与京城的通途。&nbsp;<br />
 &nbsp;&nbsp;&nbsp; 7、蹄窝密布的牛角岭关城，见证着昔日经由此处遍藏乌金、驮队铃响、运输之忙。<br />
 &nbsp;&nbsp;&nbsp; 8、枯藤老树昏鸦，小桥流水人家&hellip;&hellip;韭园村有一元代古宅，村民世代相传说这里就是马致远故居。马致远的秋思写的是千古绝句，小桥流水人家更是绝佳的景致。<br />
 &nbsp;</p>
', N'<p>
 村内的老屋荒芜着、院内假寐着老者、秋思之祖忆着小桥流水人家。<br />
 &nbsp;&nbsp;&nbsp; 韭园村的文化遗迹，千年古道，流淌着古道西风瘦马的畅想，古道悠悠担起大漠与京城的通途。 落坡村有一座神秘的碉楼，山寨，联系碉楼与山寨的秘密地道更增添了无尽的神秘。 枯藤老树昏鸦，小桥流水人家，古道西风瘦马，夕阳夕下，断肠人在天涯，马致远的秋思写的是千古绝句。 历史文化与现代文化的共存、描摹乡村的风土人情；回顾韭园生存轨迹，乡土文学的创作历程；探寻韭园未来走向，与时间约定、向未来奔跑。<br />
 &nbsp;</p>
', 0, 1, CAST(0x0000A1E901737E95 AS DateTime), 1, CAST(0x0000A227014FE580 AS DateTime))
INSERT [dbo].[webbeautifulvillage] ([AutoID], [Title], [CustomerID], [TownID], [VillageID], [Status], [Intro], [Yield], [Live], [Environment], [Humanism], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'', 0, 1, 0, 0, N'', N'', N'', N'', N'', 0, 1, CAST(0x0000A22500EE1BA9 AS DateTime), 1, CAST(0x0000A22500EE1BA9 AS DateTime))
SET IDENTITY_INSERT [dbo].[webbeautifulvillage] OFF
/****** Object:  Table [dbo].[web_customer_menu]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[web_customer_menu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[web_customer_menu](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[MenuID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__web_cust__6B2329656A50C1DA] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户网站菜单关系自增长ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'MenuID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'网站菜单id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'MenuID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'web_customer_menu', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'web_customer_menu', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[web_customer_menu] ON
INSERT [dbo].[web_customer_menu] ([AutoID], [MenuID], [CustomerID], [Status], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 1, 0, 1, 0, 1, CAST(0x0000A1CD00E3DD98 AS DateTime), 1, CAST(0x0000A1CD00E3DD98 AS DateTime))
INSERT [dbo].[web_customer_menu] ([AutoID], [MenuID], [CustomerID], [Status], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 2, 0, 1, 0, 1, CAST(0x0000A1CD00F3D518 AS DateTime), 1, CAST(0x0000A1CD00F3D518 AS DateTime))
INSERT [dbo].[web_customer_menu] ([AutoID], [MenuID], [CustomerID], [Status], [OrderValue], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 3, 0, 1, 0, 1, CAST(0x0000A22A016895C4 AS DateTime), 1, CAST(0x0000A22A016895C4 AS DateTime))
SET IDENTITY_INSERT [dbo].[web_customer_menu] OFF
/****** Object:  Table [dbo].[systemuser]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemuser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemuser](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[UserPassword] [varchar](2000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[RealName] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[IdentityCard] [varchar](18) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[UserSex] [varchar](1) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Phone] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[MobilePhone] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[UserQQ] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[UserEmail] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Address] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__systemus__6B2329652334397B] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'UserPassword'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'UserPassword'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'RealName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'RealName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'IdentityCard'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'IdentityCard'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户状态-1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'Phone'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'Phone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'MobilePhone'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'移动电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'MobilePhone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'UserQQ'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'UserQQ'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'Address'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'Address'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemuser', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemuser', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[systemuser] ON
INSERT [dbo].[systemuser] ([AutoID], [CustomerID], [Title], [UserPassword], [RealName], [IdentityCard], [UserSex], [Status], [Phone], [MobilePhone], [UserQQ], [UserEmail], [Address], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 0, N'admin', N'6A3D6D38B5F7F883', N'王渝友', N'320321198101107210', N'1', 1, N'051288886666', N'18610773181', N'81672628', N'wyy99520@yahoo.com.cn', N'', 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A2160177172B AS DateTime))
INSERT [dbo].[systemuser] ([AutoID], [CustomerID], [Title], [UserPassword], [RealName], [IdentityCard], [UserSex], [Status], [Phone], [MobilePhone], [UserQQ], [UserEmail], [Address], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 1, N'admin7', N'6A3D6D38B5F7F883', N'马楼乡政府_1', N'', N'', 1, N'', N'', N'', N'', N'', 0, N'客户id：1', 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[systemuser] ([AutoID], [CustomerID], [Title], [UserPassword], [RealName], [IdentityCard], [UserSex], [Status], [Phone], [MobilePhone], [UserQQ], [UserEmail], [Address], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 3, N'admin8', N'6A3D6D38B5F7F883', N'范楼镇政府_3', N'', N'', 1, N'', N'', N'', N'', N'', 0, N'客户id：3', 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
SET IDENTITY_INSERT [dbo].[systemuser] OFF
/****** Object:  Table [dbo].[systemrole]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemrole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemrole](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色状态-1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemrole', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemrole', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[systemrole] ON
INSERT [dbo].[systemrole] ([AutoID], [CustomerID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 0, N'高级管理员', 1, 1234, N'344565', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A181015D2E96 AS DateTime))
INSERT [dbo].[systemrole] ([AutoID], [CustomerID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 1, N'系统管理员', 1, 0, N'', 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[systemrole] ([AutoID], [CustomerID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 3, N'系统管理员', 1, 0, N'', 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
SET IDENTITY_INSERT [dbo].[systemrole] OFF
/****** Object:  Table [dbo].[systemmenu]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemmenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemmenu](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[MenuUrl] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Alt] [varchar](200) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[IsSuperAdmin] [tinyint] NOT NULL,
	[IsTopMenu] [int] NOT NULL,
	[TopMenuID] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[MenuType] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__systemme__6B23296550FB042B] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'MenuUrl'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单Url' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'MenuUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'Alt'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'Alt'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'IsSuperAdmin'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否专属超级管理员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'IsSuperAdmin'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'IsTopMenu'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否顶级菜单，1：是， 0：不是' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'IsTopMenu'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'TopMenuID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属的顶级菜单ID,二级和三级菜单所属顶级菜单ID,如是顶级菜单显示0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'TopMenuID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'ParentId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属的上级菜单ID，顶级菜单和二级菜单都为0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'MenuType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单类型:0:主页面,2：分页面,1:分页面（必须要新增 修改 删除） ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'MenuType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单状态-1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'systemmenu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemmenu', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemmenu', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[systemmenu] ON
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 0, N'系统中心', N'', N'', 0, 1, 0, 0, N'', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A18601040C17 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 0, N'系统管理', N'', N'', 0, 0, 1, 0, N'', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A181016DDBDE AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 0, N'用户设置', N'admin/systemset/systemuser.aspx', N'', 0, 0, 1, 2, N'0', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A15B00EEEE48 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, 0, N'用户设置--新增/修改', N'admin/systemset/systemuserdetail.aspx', N'', 0, 0, 1, 2, N'1', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 0, CAST(0x0000A0AF00000000 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, 0, N'角色设置', N'admin/systemset/systemrole.aspx', N'', 0, 0, 1, 2, N'0', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A181011D1A29 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, 0, N'角色设置--新增/修改', N'admin/systemset/systemroledetail.aspx', N'', 0, 0, 1, 2, N'1', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 0, CAST(0x0000A0AF00000000 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (7, 0, N'资源设置', N'admin/systemset/systemmenu.aspx', N'', 0, 0, 1, 2, N'0', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1810172EBB3 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (8, 0, N'资源设置--新增/修改', N'admin/systemset/systemmenudetail.aspx', N'', 1, 0, 1, 2, N'1', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 0, CAST(0x0000A0AF00000000 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (9, 0, N'授予角色', N'admin/systemset/awardrole.aspx', N'', 0, 0, 1, 2, N'2', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A15A0179B221 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (10, 0, N'授予资源', N'admin/systemset/awardmenu.aspx', N'', 0, 0, 1, 2, N'2', 1, 0, N'', 0, CAST(0x0000A0AF00000000 AS DateTime), 0, CAST(0x0000A0AF00000000 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (11, 0, N'修改个人信息', N'admin/systemset/edituser.aspx', N'', 0, 0, 1, 2, N'0', 1, 0, N'', 1, CAST(0x0000A17D0178487C AS DateTime), 1, CAST(0x0000A17D017A320B AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (12, 0, N'基础信息设置', N'admin/systemset/baseinfoset.aspx', N'', 0, 0, 1, 2, N'0', 1, 0, N'', 1, CAST(0x0000A192016F2743 AS DateTime), 1, CAST(0x0000A192016FAA24 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (13, 0, N'客户管理', N'', N'', 1, 0, 1, 0, N'', 1, 0, N'', 0, CAST(0x0000A14200A22BA8 AS DateTime), 1, CAST(0x0000A1A2014CF07E AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (14, 0, N'客户设置', N'admin/systemset/systemcustomer.aspx', N'', 1, 0, 1, 13, N'0', 1, 0, N'', 1, CAST(0x0000A14200AF8F70 AS DateTime), 1, CAST(0x0000A1A20172A968 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (15, 0, N'客户设置--新增修改', N'admin/systemset/systemcustomerdetail.aspx', N'', 1, 0, 1, 13, N'1', 1, 0, N'', 1, CAST(0x0000A14200AC4F53 AS DateTime), 1, CAST(0x0000A1A201729B90 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (16, 0, N'域名设置', N'admin/systemset/systemdomain.aspx', N'', 1, 0, 1, 13, N'0', 1, 0, N'', 1, CAST(0x0000A14200BABAE3 AS DateTime), 1, CAST(0x0000A1A20172BE07 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (17, 0, N'域名设置--新增/修改', N'admin/systemset/systemdomaindetail.aspx', N'', 1, 0, 1, 13, N'1', 1, 0, N'', 1, CAST(0x0000A14200F9056C AS DateTime), 1, CAST(0x0000A1A20172CF05 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (18, 0, N'客户域名绑定', N'admin/systemset/systemdomainbind.aspx', N'', 1, 0, 1, 13, N'0', 1, 0, N'', 1, CAST(0x0000A15A017408F5 AS DateTime), 1, CAST(0x0000A1A20172DE99 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (19, 0, N'客户域名绑定--新增/修改', N'admin/systemset/systemdomainbinddetail.aspx', N'', 1, 0, 1, 13, N'1', 1, 0, N'', 1, CAST(0x0000A15A0179D6F0 AS DateTime), 1, CAST(0x0000A1A20173A30A AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (20, 0, N'客户域名授权', N'admin/systemset/systemcustomerpurview.aspx', N'', 1, 0, 1, 13, N'2', 1, 0, N'', 1, CAST(0x0000A15A017A03DF AS DateTime), 1, CAST(0x0000A1A2017305AE AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (21, 0, N'省、直辖市设置', N'admin/systemset/areaprovinceset.aspx', N'', 1, 0, 1, 25, N'0', 1, 0, N'', 1, CAST(0x0000A1B60103EB75 AS DateTime), 1, CAST(0x0000A1BA00EA3E11 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (22, 0, N'省、直辖市设置--新增修改', N'admin/systemset/areaprovincesetdetail.aspx', N'', 1, 0, 1, 25, N'1', 1, 0, N'', 1, CAST(0x0000A1B6010465D3 AS DateTime), 1, CAST(0x0000A1BA00EA5095 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (23, 0, N'城市设置', N'admin/systemset/areacityset.aspx', N'', 1, 0, 1, 25, N'0', 1, 0, N'', 1, CAST(0x0000A1B6010644E2 AS DateTime), 1, CAST(0x0000A1BA00EA6866 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (24, 0, N'城市设置--新增修改', N'admin/systemset/areacitysetdetail.aspx', N'', 1, 0, 1, 25, N'1', 1, 0, N'', 1, CAST(0x0000A1B601068CC0 AS DateTime), 1, CAST(0x0000A1BA00EA7561 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (25, 0, N'区域管理', N'', N'', 1, 0, 1, 0, N'', 1, 0, N'', 1, CAST(0x0000A1BA00E708DB AS DateTime), 1, CAST(0x0000A1BA00E708DB AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (26, 0, N'县、区设置', N'admin/systemset/areacountyset.aspx', N'', 1, 0, 1, 25, N'0', 1, 0, N'', 1, CAST(0x0000A1BA00E76790 AS DateTime), 1, CAST(0x0000A1BA00E76790 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (27, 0, N'县、区设置--新增修改', N'admin/systemset/areacountysetdetail.aspx', N'', 1, 0, 1, 25, N'1', 1, 0, N'', 1, CAST(0x0000A1BA00E7B6C6 AS DateTime), 1, CAST(0x0000A1BA00E7D61C AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (28, 0, N'乡镇设置', N'admin/systemset/areatownset.aspx', N'', 1, 0, 1, 25, N'0', 1, 0, N'', 1, CAST(0x0000A1BA00E8D85E AS DateTime), 1, CAST(0x0000A1BA00E8D85E AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (29, 0, N'乡镇设置--新增修改', N'admin/systemset/areatownsetdetail.aspx', N'', 1, 0, 1, 25, N'1', 1, 0, N'', 1, CAST(0x0000A1BA00E9534C AS DateTime), 1, CAST(0x0000A1BA00EAF3B5 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (30, 0, N'乡村设置', N'admin/systemset/areavillageset.aspx', N'', 1, 0, 1, 25, N'0', 1, 0, N'', 1, CAST(0x0000A1BA00E9D083 AS DateTime), 1, CAST(0x0000A1BA00E9D083 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (31, 0, N'乡村设置--新增修改', N'admin/systemset/areavillagesetdetail.aspx', N'', 1, 0, 1, 25, N'1', 1, 0, N'', 1, CAST(0x0000A1BA00EA1C84 AS DateTime), 1, CAST(0x0000A1BA00EA1C84 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (32, 0, N'网站中心', N'', N'', 0, 1, 0, 0, N'', 1, 0, N'', 1, CAST(0x0000A1BE0165A343 AS DateTime), 1, CAST(0x0000A1BE0165A343 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (33, 0, N'网站管理', N'', N'', 0, 0, 32, 0, N'', 1, 0, N'', 1, CAST(0x0000A1C30098DD9C AS DateTime), 1, CAST(0x0000A1C30098DD9C AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (34, 0, N'菜单设置', N'admin/webset/webmenuset.aspx', N'', 0, 0, 32, 33, N'0', 1, 0, N'', 1, CAST(0x0000A1C300991516 AS DateTime), 1, CAST(0x0000A1C300991516 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (35, 0, N'菜单设置--新增修改', N'admin/webset/webmenusetdetail.aspx', N'', 0, 0, 32, 33, N'1', 1, 0, N'', 1, CAST(0x0000A1CC00E55FAF AS DateTime), 1, CAST(0x0000A1CC00E5AE4F AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (36, 0, N'资讯速递', N'admin/webset/farmingnews.aspx', N'', 0, 0, 32, 33, N'0', 1, 0, N'', 1, CAST(0x0000A1D800EBBD57 AS DateTime), 1, CAST(0x0000A1D801546D67 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (37, 0, N'资讯速递--新增修改', N'admin/webset/farmingnewsdetail.aspx', N'', 0, 0, 32, 33, N'1', 1, 0, N'', 1, CAST(0x0000A1E00112E718 AS DateTime), 1, CAST(0x0000A1E001131452 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (38, 0, N' 魅力乡村', N'admin/webset/beautifulvillage.aspx', N'', 0, 0, 32, 33, N'0', 1, 0, N'', 1, CAST(0x0000A1E80112E626 AS DateTime), 1, CAST(0x0000A1E80112E626 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (39, 0, N'魅力乡村--新增修改', N'admin/webset/beautifulvillagedetail.aspx', N'', 0, 0, 32, 33, N'1', 1, 0, N'', 1, CAST(0x0000A1E801132365 AS DateTime), 1, CAST(0x0000A21300A669E5 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (40, 0, N'图片设置', N'admin/webset/imageset.aspx', N'', 0, 0, 32, 33, N'0', 1, 0, N'', 1, CAST(0x0000A21100A55383 AS DateTime), 1, CAST(0x0000A21100A55383 AS DateTime))
INSERT [dbo].[systemmenu] ([AutoID], [CustomerID], [Title], [MenuUrl], [Alt], [IsSuperAdmin], [IsTopMenu], [TopMenuID], [ParentId], [MenuType], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (41, 0, N'图片设置--新增修改', N'admin/webset/imageset.aspx', N'', 0, 0, 32, 33, N'1', 1, 0, N'', 1, CAST(0x0000A21100A58692 AS DateTime), 1, CAST(0x0000A21100A58692 AS DateTime))
SET IDENTITY_INSERT [dbo].[systemmenu] OFF
/****** Object:  Table [dbo].[systemlog]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemlog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemlog](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[datetime] [datetime] NOT NULL,
	[loginfo] [varchar](500) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Particular] [varchar](1000) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_systemlog] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[systemdomain]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemdomain]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemdomain](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'域名ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'域名名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'域名状态-1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemdomain', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemdomain', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[systemdomain] ON
INSERT [dbo].[systemdomain] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'localhost:10944', 1, 0, N'', 1, CAST(0x0000A1A300A47F47 AS DateTime), 1, CAST(0x0000A1AA014D6B91 AS DateTime))
INSERT [dbo].[systemdomain] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'localhost', 1, 0, N'', 1, CAST(0x0000A1A300F4E437 AS DateTime), 1, CAST(0x0000A1AA014F45A2 AS DateTime))
SET IDENTITY_INSERT [dbo].[systemdomain] OFF
/****** Object:  Table [dbo].[systemcustomer]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[systemcustomer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[systemcustomer](
	[AutoID] [int] IDENTITY(0,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[LinkMan] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Phone] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[MobilePhone] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[QQ] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Fax] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Email] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Address] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OrderValue] [int] NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[CountyID] [int] NOT NULL,
	[TownID] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[OpenStatus] [tinyint] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
 CONSTRAINT [PK__systemcu__6B2329650697FACD] PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户状态，-1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'LinkMan'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'LinkMan'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Phone'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Phone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'MobilePhone'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'移动电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'MobilePhone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'QQ'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'QQ'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Fax'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真Fax' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Fax'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Email'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Email'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Address'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Address'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'systemcustomer', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'systemcustomer', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[systemcustomer] ON
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (0, N'梁寨镇政府', 1, N'王渝友', N'051288886666', N'18610773181', N'81672628', N'051266668888', N'', N'江苏苏州', 88, 4, 1, 1, 1, N'', 1, 1, CAST(0x0000A1AA00BA865B AS DateTime), 1, CAST(0x0000A22400D9AED4 AS DateTime))
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'马楼乡政府', 1, N'吴星光', N'', N'', N'', N'', N'', N'', 0, 4, 1, 1, 5, N'', 2, 1, CAST(0x0000A1AA0100BF34 AS DateTime), 1, CAST(0x0000A2030104E715 AS DateTime))
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'李寨镇政府', 1, N'', N'', N'', N'', N'', N'', N'', 0, 4, 1, 1, 2, N'', 0, 1, CAST(0x0000A1AA0100D817 AS DateTime), 1, CAST(0x0000A1DA01611A7F AS DateTime))
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'范楼镇政府', 1, N'', N'', N'', N'', N'', N'', N'', 0, 4, 1, 1, 4, N'', 1, 1, CAST(0x0000A1AA01016673 AS DateTime), 1, CAST(0x0000A223016446FB AS DateTime))
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'华山镇政府', 1, N'', N'', N'', N'', N'', N'', N'', 0, 0, 0, 0, 0, N'', 0, 1, CAST(0x0000A1AA01019653 AS DateTime), 1, CAST(0x0000A1AA01019653 AS DateTime))
INSERT [dbo].[systemcustomer] ([AutoID], [Title], [Status], [LinkMan], [Phone], [MobilePhone], [QQ], [Fax], [Email], [Address], [OrderValue], [ProvinceID], [CityID], [CountyID], [TownID], [Remark], [OpenStatus], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'大沙河镇政府', 1, N'', N'', N'', N'', N'', N'', N'', 0, 0, 0, 0, 0, N'', 0, 1, CAST(0x0000A1AA0101A9DB AS DateTime), 1, CAST(0x0000A1AA0101A9DB AS DateTime))
SET IDENTITY_INSERT [dbo].[systemcustomer] OFF
/****** Object:  Table [dbo].[system_user_role]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_user_role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[system_user_role](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色关系ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'UserID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'UserID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_user_role', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_user_role', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[system_user_role] ON
INSERT [dbo].[system_user_role] ([AutoID], [UserID], [RoleID], [CustomerID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 1, 1, 0, 0, CAST(0x0000A0AF00000000 AS DateTime), 0, CAST(0x0000A0AF00000000 AS DateTime))
INSERT [dbo].[system_user_role] ([AutoID], [UserID], [RoleID], [CustomerID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 2, 2, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_user_role] ([AutoID], [UserID], [RoleID], [CustomerID], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 3, 3, 3, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
SET IDENTITY_INSERT [dbo].[system_user_role] OFF
/****** Object:  Table [dbo].[system_role_menu]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_role_menu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[system_role_menu](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[IsShowMenu] [tinyint] NOT NULL,
	[IsPurview] [tinyint] NOT NULL,
	[IsAdd] [tinyint] NOT NULL,
	[IsView] [tinyint] NOT NULL,
	[IsEdit] [tinyint] NOT NULL,
	[IsDelete] [tinyint] NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色菜单关系ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'RoleID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'MenuID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'MenuID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsShowMenu'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsShowMenu'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsPurview'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有权限 1：是，0否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsPurview'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsAdd'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否新增 1：是，0否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsAdd'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsView'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否预览 1：是，0否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsEdit'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否修改 1：是，0否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsEdit'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'IsDelete'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除 1：是，0否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_role_menu', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_role_menu', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[system_role_menu] ON
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1A2016DBE78 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, 1, 2, 0, 0, 1, 0, 0, 0, 0, 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1A2016E0018 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, 1, 3, 0, 1, 1, 0, 0, 0, 0, 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1A2016DE9D4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, 1, 4, 0, 0, 1, 1, 1, 1, 1, 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1A2016DF7E4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, 1, 5, 0, 1, 1, 0, 0, 0, 0, 0, CAST(0x0000A0AF00000000 AS DateTime), 1, CAST(0x0000A1A2016DE2CC AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, 1, 13, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DCB5C AS DateTime), 1, CAST(0x0000A1A2016DCB5C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (7, 1, 7, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DD4BC AS DateTime), 1, CAST(0x0000A1A2016DEE84 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (8, 1, 9, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DD714 AS DateTime), 1, CAST(0x0000A1A2016DD714 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (9, 1, 12, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DDBC4 AS DateTime), 1, CAST(0x0000A1A2016DF0DC AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (10, 1, 11, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DDCF0 AS DateTime), 1, CAST(0x0000A1A2016DF208 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (11, 1, 10, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2016DDE1C AS DateTime), 1, CAST(0x0000A1A2016DDE1C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (12, 1, 8, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1A2016DDF48 AS DateTime), 1, CAST(0x0000A1A2016DFB68 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (13, 1, 6, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1A2016DDF48 AS DateTime), 1, CAST(0x0000A1A2016DFA3C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (14, 1, 14, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A201733F10 AS DateTime), 1, CAST(0x0000A1A2017357AC AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (15, 1, 16, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A201734294 AS DateTime), 1, CAST(0x0000A1A201735554 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (16, 1, 17, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1A2017343C0 AS DateTime), 1, CAST(0x0000A1A201736238 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (17, 1, 18, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2017344EC AS DateTime), 1, CAST(0x0000A1A2017352FC AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (18, 1, 19, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1A201734618 AS DateTime), 1, CAST(0x0000A1A201736364 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (19, 1, 20, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1A2017350A4 AS DateTime), 1, CAST(0x0000A1A2017350A4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (20, 1, 15, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1A201735680 AS DateTime), 1, CAST(0x0000A1A300A68C54 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (21, 1, 21, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1B60106B714 AS DateTime), 1, CAST(0x0000A1B60106BE1C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (22, 1, 23, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1B60106B96C AS DateTime), 1, CAST(0x0000A1B60106C1A0 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (23, 1, 22, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1B60106BA98 AS DateTime), 1, CAST(0x0000A1B60106D6B8 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (24, 1, 24, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1B60106BBC4 AS DateTime), 1, CAST(0x0000A1B901822EE4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (25, 1, 25, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1BA00EAA650 AS DateTime), 1, CAST(0x0000A1BA00EAA650 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (26, 1, 26, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1BA00EAA8A8 AS DateTime), 1, CAST(0x0000A1BA00EAC39C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (27, 1, 27, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1BA00EAA9D4 AS DateTime), 1, CAST(0x0000A1BA00EAC84C AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (28, 1, 28, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1BA00EAAB00 AS DateTime), 1, CAST(0x0000A1BA00EABDC0 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (29, 1, 29, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1BA00EAAFB0 AS DateTime), 1, CAST(0x0000A1BA00EB1478 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (30, 1, 30, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1BA00EAB0DC AS DateTime), 1, CAST(0x0000A1BA00EABB68 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (31, 1, 31, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1BA00EAB208 AS DateTime), 1, CAST(0x0000A1BA00EAB7E4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (32, 1, 32, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1BE0165B5D4 AS DateTime), 1, CAST(0x0000A1BE0165B5D4 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (33, 1, 33, 0, 0, 1, 0, 0, 0, 0, 1, CAST(0x0000A1C3009C5388 AS DateTime), 1, CAST(0x0000A1C3009C5388 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (34, 1, 34, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1C3009C570C AS DateTime), 1, CAST(0x0000A1C3009C5838 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (35, 1, 35, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1CC00E64984 AS DateTime), 1, CAST(0x0000A1CC00E65794 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (36, 1, 36, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1D80153F420 AS DateTime), 1, CAST(0x0000A1FE0166AE44 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (37, 1, 37, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1E001131DB0 AS DateTime), 1, CAST(0x0000A1E001132260 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (38, 1, 38, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A1E900DF0CC8 AS DateTime), 1, CAST(0x0000A1E900DF0F20 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (39, 1, 39, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A1E900DF0CC8 AS DateTime), 1, CAST(0x0000A1FF00E7AC98 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (40, 1, 40, 0, 1, 1, 0, 0, 0, 0, 1, CAST(0x0000A21100AE5484 AS DateTime), 1, CAST(0x0000A21100AE5934 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (41, 1, 41, 0, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A21100AE55B0 AS DateTime), 1, CAST(0x0000A21100AE5CB8 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (42, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (43, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (44, 2, 3, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (45, 2, 4, 1, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (46, 2, 5, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (47, 2, 6, 1, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (48, 2, 7, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (49, 2, 8, 1, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (50, 2, 9, 1, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (51, 2, 10, 1, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (52, 2, 11, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (53, 2, 12, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230147BD72 AS DateTime), 1, CAST(0x0000A2230147BD72 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (54, 3, 1, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (55, 3, 2, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (56, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (57, 3, 4, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (58, 3, 5, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (59, 3, 6, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (60, 3, 7, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (61, 3, 8, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (62, 3, 9, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (63, 3, 10, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (64, 3, 11, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (65, 3, 12, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (66, 3, 32, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (67, 3, 33, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (68, 3, 34, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (69, 3, 35, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (70, 3, 36, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (71, 3, 37, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (72, 3, 38, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (73, 3, 39, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (74, 3, 40, 3, 1, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
INSERT [dbo].[system_role_menu] ([AutoID], [RoleID], [MenuID], [CustomerID], [IsShowMenu], [IsPurview], [IsAdd], [IsView], [IsEdit], [IsDelete], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (75, 3, 41, 3, 0, 1, 1, 1, 1, 1, 1, CAST(0x0000A2230157DD69 AS DateTime), 1, CAST(0x0000A2230157DD69 AS DateTime))
SET IDENTITY_INSERT [dbo].[system_role_menu] OFF
/****** Object:  Table [dbo].[system_customer_domain]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[system_customer_domain]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[system_customer_domain](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[DomainID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户域名关系ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'CustomerID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'DomainID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'域名ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'DomainID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否启用 1：启用，0：未启用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'system_customer_domain', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'system_customer_domain', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[system_customer_domain] ON
INSERT [dbo].[system_customer_domain] ([AutoID], [CustomerID], [DomainID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, 0, 1, 0, 0, N'', 1, CAST(0x0000A1AA010B9AAC AS DateTime), 1, CAST(0x0000A1AA010B9AAC AS DateTime))
INSERT [dbo].[system_customer_domain] ([AutoID], [CustomerID], [DomainID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, 3, 2, 0, 0, N'', 1, CAST(0x0000A2230157CDA3 AS DateTime), 1, CAST(0x0000A2230157CDA3 AS DateTime))
SET IDENTITY_INSERT [dbo].[system_customer_domain] OFF
/****** Object:  Table [dbo].[areavillage]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areavillage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areavillage](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[CountyID] [int] NOT NULL,
	[TownID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'村ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'村名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'ProvinceID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'CityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'CityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'CountyID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'县ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'CountyID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'TownID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡镇ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'TownID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areavillage', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areavillage', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[areavillage] ON
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'周楼村', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1BE015FCE7A AS DateTime), 1, CAST(0x0000A1DF01792427 AS DateTime))
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'梁寨村', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1DF017918DF AS DateTime), 1, CAST(0x0000A1DF017918DF AS DateTime))
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'西高头村', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E8010E4EFD AS DateTime), 1, CAST(0x0000A1E8010E4EFD AS DateTime))
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'黄楼', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E801105EB1 AS DateTime), 1, CAST(0x0000A1E801105EB1 AS DateTime))
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'腾楼', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E801108242 AS DateTime), 1, CAST(0x0000A1E801108242 AS DateTime))
INSERT [dbo].[areavillage] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [TownID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, N'华祖庙村', 4, 1, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E80110A73C AS DateTime), 1, CAST(0x0000A1E80110A73C AS DateTime))
SET IDENTITY_INSERT [dbo].[areavillage] OFF
/****** Object:  Table [dbo].[areatown]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areatown]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areatown](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[CountyID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡镇ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乡镇名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'ProvinceID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'CityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'CityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'CountyID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'县ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'CountyID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areatown', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areatown', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[areatown] ON
INSERT [dbo].[areatown] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'梁寨镇', 4, 1, 1, 1, 0, N'', 1, CAST(0x0000A1BD016B0760 AS DateTime), 1, CAST(0x0000A1E801112D3A AS DateTime))
INSERT [dbo].[areatown] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'李寨乡', 4, 1, 1, 1, 0, N'', 1, CAST(0x0000A1BD016F06B2 AS DateTime), 1, CAST(0x0000A1E8011137B8 AS DateTime))
INSERT [dbo].[areatown] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'和集乡', 4, 1, 1, 1, 0, N'', 1, CAST(0x0000A1BE015C52C5 AS DateTime), 1, CAST(0x0000A1E801114269 AS DateTime))
INSERT [dbo].[areatown] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'孙楼乡', 4, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E80110D038 AS DateTime), 1, CAST(0x0000A1E80110D038 AS DateTime))
INSERT [dbo].[areatown] ([AutoID], [Title], [ProvinceID], [CityID], [CountyID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'马楼乡', 4, 1, 1, 1, 0, N'', 1, CAST(0x0000A1E801112234 AS DateTime), 1, CAST(0x0000A1E801112234 AS DateTime))
SET IDENTITY_INSERT [dbo].[areatown] OFF
/****** Object:  Table [dbo].[areaprovince]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areaprovince]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areaprovince](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areaprovince', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areaprovince', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[areaprovince] ON
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'北京', 1, 0, N'', 1, CAST(0x0000A1B900FE6636 AS DateTime), 1, CAST(0x0000A1B900FE6636 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'发发', 2, 0, N'', 1, CAST(0x0000A1B90101FBFF AS DateTime), 1, CAST(0x0000A1B90101FBFF AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'fatqew', 2, 0, N'', 1, CAST(0x0000A1B90102070C AS DateTime), 1, CAST(0x0000A1B90102070C AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'江苏', 1, 0, N'', 1, CAST(0x0000A1B90109DA83 AS DateTime), 1, CAST(0x0000A1B90109DA83 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'安徽', 1, 0, N'', 1, CAST(0x0000A1B90109E646 AS DateTime), 1, CAST(0x0000A1B90109E646 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, N'山东', 1, 0, N'', 1, CAST(0x0000A1B90109F0DD AS DateTime), 1, CAST(0x0000A1B90109F0DD AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (7, N'天津', 1, 0, N'', 1, CAST(0x0000A1B90109F90F AS DateTime), 1, CAST(0x0000A1B90109F90F AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (8, N'河北', 1, 0, N'', 1, CAST(0x0000A1B9010A03E2 AS DateTime), 1, CAST(0x0000A1B9010A03E2 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (9, N'浙江', 1, 0, N'', 1, CAST(0x0000A1B9010A0C4C AS DateTime), 1, CAST(0x0000A1B9010BEBC2 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (10, N'上海', 1, 0, N'', 1, CAST(0x0000A1B9010A1540 AS DateTime), 1, CAST(0x0000A1B9010A1540 AS DateTime))
INSERT [dbo].[areaprovince] ([AutoID], [Title], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (11, N'河南', 1, 0, N'', 1, CAST(0x0000A1B9010A29C3 AS DateTime), 1, CAST(0x0000A1B9010BFDBD AS DateTime))
SET IDENTITY_INSERT [dbo].[areaprovince] OFF
/****** Object:  Table [dbo].[areacounty]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areacounty]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areacounty](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'县、区ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'县、区名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'ProvinceID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'CityID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'CityID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacounty', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacounty', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[areacounty] ON
INSERT [dbo].[areacounty] ([AutoID], [Title], [ProvinceID], [CityID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'丰县', 4, 1, 1, 0, N'', 1, CAST(0x0000A1BB018A04DD AS DateTime), 1, CAST(0x0000A1BB018A04DD AS DateTime))
INSERT [dbo].[areacounty] ([AutoID], [Title], [ProvinceID], [CityID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'沛县', 4, 1, 1, 0, N'', 1, CAST(0x0000A1BC0000C7B3 AS DateTime), 1, CAST(0x0000A1BC0000C7B3 AS DateTime))
INSERT [dbo].[areacounty] ([AutoID], [Title], [ProvinceID], [CityID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'工业园区', 4, 3, 1, 0, N'', 1, CAST(0x0000A1BC00D53542 AS DateTime), 1, CAST(0x0000A1BC00D53542 AS DateTime))
INSERT [dbo].[areacounty] ([AutoID], [Title], [ProvinceID], [CityID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'铜山', 4, 1, 1, 0, N'', 1, CAST(0x0000A1BC00D66A24 AS DateTime), 1, CAST(0x0000A1BC00D66A24 AS DateTime))
INSERT [dbo].[areacounty] ([AutoID], [Title], [ProvinceID], [CityID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'昆山', 4, 3, 1, 0, N'', 1, CAST(0x0000A1BC00D680AB AS DateTime), 1, CAST(0x0000A1BC00DF2F43 AS DateTime))
SET IDENTITY_INSERT [dbo].[areacounty] OFF
/****** Object:  Table [dbo].[areacity]    Script Date: 10/10/2013 22:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[areacity]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[areacity](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderValue] [int] NOT NULL,
	[Remark] [varchar](4000) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[CreatorID] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Modifier] [int] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'AutoID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'AutoID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'ProvinceID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效 1：有效，0：无效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'OrderValue'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'OrderValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'CreatorID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'Modifier'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'Modifier'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'areacity', N'COLUMN',N'ModifyDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'areacity', @level2type=N'COLUMN',@level2name=N'ModifyDate'
GO
SET IDENTITY_INSERT [dbo].[areacity] ON
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (1, N'徐州', 4, 1, 0, N'', 1, CAST(0x0000A1B901825065 AS DateTime), 1, CAST(0x0000A1BA00D9CB2D AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (2, N'南京', 4, 1, 0, N'', 1, CAST(0x0000A1B9018357CA AS DateTime), 1, CAST(0x0000A1BA00D8864F AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (3, N'苏州', 4, 1, 0, N'', 1, CAST(0x0000A1BA00D5F3A6 AS DateTime), 1, CAST(0x0000A1BA00D5F3A6 AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (4, N'济南', 6, 1, 0, N'', 1, CAST(0x0000A1BA00D9B17D AS DateTime), 1, CAST(0x0000A1BA00D9B17D AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (5, N'无锡', 4, 1, 0, N'', 1, CAST(0x0000A1BA00E02A43 AS DateTime), 1, CAST(0x0000A1BA00E2D326 AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (6, N'合肥', 5, 1, 0, N'', 1, CAST(0x0000A1BA00E31957 AS DateTime), 1, CAST(0x0000A1BA00E32BE9 AS DateTime))
INSERT [dbo].[areacity] ([AutoID], [Title], [ProvinceID], [Status], [OrderValue], [Remark], [CreatorID], [CreateDate], [Modifier], [ModifyDate]) VALUES (7, N'连云港', 4, 0, 0, N'', 1, CAST(0x0000A1ED0004070E AS DateTime), 1, CAST(0x0000A1ED0004070E AS DateTime))
SET IDENTITY_INSERT [dbo].[areacity] OFF
/****** Object:  Default [DF__areacity__Title__5224328E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Title__5224328E]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Title__5224328E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__areacity__Provin__531856C7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Provin__531856C7]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Provin__531856C7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF__areacity__Status__540C7B00]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Status__540C7B00]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Status__540C7B00]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__areacity__OrderV__55009F39]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__OrderV__55009F39]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__OrderV__55009F39]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__areacity__Remark__55F4C372]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Remark__55F4C372]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Remark__55F4C372]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__areacity__Creato__56E8E7AB]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Creato__56E8E7AB]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Creato__56E8E7AB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__areacity__Create__57DD0BE4]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Create__57DD0BE4]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Create__57DD0BE4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__areacity__Modifi__58D1301D]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Modifi__58D1301D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Modifi__58D1301D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__areacity__Modify__59C55456]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacity__Modify__59C55456]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacity]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacity__Modify__59C55456]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacity] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__areacount__Title__44CA3770]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Title__44CA3770]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Title__44CA3770]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__areacount__Provi__45BE5BA9]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Provi__45BE5BA9]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Provi__45BE5BA9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF__areacount__CityI__46B27FE2]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__CityI__46B27FE2]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__CityI__46B27FE2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [CityID]
END


End
GO
/****** Object:  Default [DF__areacount__Statu__47A6A41B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Statu__47A6A41B]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Statu__47A6A41B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__areacount__Order__489AC854]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Order__489AC854]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Order__489AC854]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__areacount__Remar__498EEC8D]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Remar__498EEC8D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Remar__498EEC8D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__areacount__Creat__4A8310C6]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Creat__4A8310C6]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Creat__4A8310C6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__areacount__Creat__4B7734FF]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Creat__4B7734FF]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Creat__4B7734FF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__areacount__Modif__4C6B5938]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Modif__4C6B5938]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Modif__4C6B5938]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__areacount__Modif__4D5F7D71]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areacount__Modif__4D5F7D71]') AND parent_object_id = OBJECT_ID(N'[dbo].[areacounty]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areacount__Modif__4D5F7D71]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areacounty] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__areaprovi__Title__395884C4]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Title__395884C4]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Title__395884C4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__areaprovi__Statu__3A4CA8FD]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Statu__3A4CA8FD]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Statu__3A4CA8FD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__areaprovi__Order__3B40CD36]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Order__3B40CD36]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Order__3B40CD36]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__areaprovi__Remar__3C34F16F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Remar__3C34F16F]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Remar__3C34F16F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__areaprovi__Creat__3D2915A8]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Creat__3D2915A8]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Creat__3D2915A8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__areaprovi__Creat__3E1D39E1]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Creat__3E1D39E1]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Creat__3E1D39E1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__areaprovi__Modif__3F115E1A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Modif__3F115E1A]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Modif__3F115E1A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__areaprovi__Modif__40058253]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areaprovi__Modif__40058253]') AND parent_object_id = OBJECT_ID(N'[dbo].[areaprovince]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areaprovi__Modif__40058253]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areaprovince] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__areatown__Title__2B0A656D]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Title__2B0A656D]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Title__2B0A656D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__areatown__Provin__2BFE89A6]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Provin__2BFE89A6]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Provin__2BFE89A6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF__areatown__CityID__2CF2ADDF]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__CityID__2CF2ADDF]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__CityID__2CF2ADDF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [CityID]
END


End
GO
/****** Object:  Default [DF__areatown__County__2DE6D218]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__County__2DE6D218]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__County__2DE6D218]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [CountyID]
END


End
GO
/****** Object:  Default [DF__areatown__Status__2EDAF651]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Status__2EDAF651]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Status__2EDAF651]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__areatown__OrderV__2FCF1A8A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__OrderV__2FCF1A8A]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__OrderV__2FCF1A8A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__areatown__Remark__30C33EC3]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Remark__30C33EC3]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Remark__30C33EC3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__areatown__Creato__31B762FC]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Creato__31B762FC]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Creato__31B762FC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__areatown__Create__32AB8735]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Create__32AB8735]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Create__32AB8735]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__areatown__Modifi__339FAB6E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Modifi__339FAB6E]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Modifi__339FAB6E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__areatown__Modify__3493CFA7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areatown__Modify__3493CFA7]') AND parent_object_id = OBJECT_ID(N'[dbo].[areatown]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areatown__Modify__3493CFA7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areatown] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__areavilla__Title__1BC821DD]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Title__1BC821DD]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Title__1BC821DD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__areavilla__Provi__1CBC4616]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Provi__1CBC4616]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Provi__1CBC4616]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF__areavilla__CityI__1DB06A4F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__CityI__1DB06A4F]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__CityI__1DB06A4F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [CityID]
END


End
GO
/****** Object:  Default [DF__areavilla__Count__1EA48E88]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Count__1EA48E88]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Count__1EA48E88]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [CountyID]
END


End
GO
/****** Object:  Default [DF__areavilla__TownI__1F98B2C1]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__TownI__1F98B2C1]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__TownI__1F98B2C1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [TownID]
END


End
GO
/****** Object:  Default [DF__areavilla__Statu__208CD6FA]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Statu__208CD6FA]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Statu__208CD6FA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__areavilla__Order__2180FB33]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Order__2180FB33]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Order__2180FB33]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__areavilla__Remar__22751F6C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Remar__22751F6C]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Remar__22751F6C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__areavilla__Creat__236943A5]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Creat__236943A5]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Creat__236943A5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__areavilla__Creat__245D67DE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Creat__245D67DE]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Creat__245D67DE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__areavilla__Modif__25518C17]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Modif__25518C17]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Modif__25518C17]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__areavilla__Modif__2645B050]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__areavilla__Modif__2645B050]') AND parent_object_id = OBJECT_ID(N'[dbo].[areavillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__areavilla__Modif__2645B050]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[areavillage] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__system_cu__Custo__02084FDA]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Custo__02084FDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Custo__02084FDA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__system_cu__Domai__02FC7413]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Domai__02FC7413]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Domai__02FC7413]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [DomainID]
END


End
GO
/****** Object:  Default [DF__system_cu__Statu__03F0984C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Statu__03F0984C]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Statu__03F0984C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__system_cu__Order__04E4BC85]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Order__04E4BC85]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Order__04E4BC85]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__system_cu__Remar__05D8E0BE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Remar__05D8E0BE]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Remar__05D8E0BE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__system_cu__Creat__06CD04F7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Creat__06CD04F7]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Creat__06CD04F7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__system_cu__Creat__07C12930]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Creat__07C12930]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Creat__07C12930]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__system_cu__Modif__08B54D69]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Modif__08B54D69]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Modif__08B54D69]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__system_cu__Modif__09A971A2]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_cu__Modif__09A971A2]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_customer_domain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_cu__Modif__09A971A2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_customer_domain] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__system_ro__RoleI__71D1E811]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__RoleI__71D1E811]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__RoleI__71D1E811]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [RoleID]
END


End
GO
/****** Object:  Default [DF__system_ro__MenuI__72C60C4A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__MenuI__72C60C4A]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__MenuI__72C60C4A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [MenuID]
END


End
GO
/****** Object:  Default [DF__system_ro__Custo__73BA3083]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Custo__73BA3083]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Custo__73BA3083]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__system_ro__IsSho__74AE54BC]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsSho__74AE54BC]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsSho__74AE54BC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsShowMenu]
END


End
GO
/****** Object:  Default [DF__system_ro__IsPur__75A278F5]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsPur__75A278F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsPur__75A278F5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsPurview]
END


End
GO
/****** Object:  Default [DF__system_ro__IsAdd__76969D2E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsAdd__76969D2E]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsAdd__76969D2E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsAdd]
END


End
GO
/****** Object:  Default [DF__system_ro__IsVie__778AC167]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsVie__778AC167]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsVie__778AC167]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsView]
END


End
GO
/****** Object:  Default [DF__system_ro__IsEdi__787EE5A0]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsEdi__787EE5A0]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsEdi__787EE5A0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsEdit]
END


End
GO
/****** Object:  Default [DF__system_ro__IsDel__797309D9]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__IsDel__797309D9]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__IsDel__797309D9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [IsDelete]
END


End
GO
/****** Object:  Default [DF__system_ro__Creat__7A672E12]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Creat__7A672E12]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Creat__7A672E12]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__system_ro__Creat__7B5B524B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Creat__7B5B524B]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Creat__7B5B524B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__system_ro__Modif__7C4F7684]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Modif__7C4F7684]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Modif__7C4F7684]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__system_ro__Modif__7D439ABD]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_ro__Modif__7D439ABD]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_role_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_ro__Modif__7D439ABD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_role_menu] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__system_us__UserI__6754599E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__UserI__6754599E]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__UserI__6754599E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ((0)) FOR [UserID]
END


End
GO
/****** Object:  Default [DF__system_us__RoleI__68487DD7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__RoleI__68487DD7]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__RoleI__68487DD7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ((0)) FOR [RoleID]
END


End
GO
/****** Object:  Default [DF__system_us__Custo__693CA210]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Custo__693CA210]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Custo__693CA210]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__system_us__Creat__6A30C649]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Creat__6A30C649]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Creat__6A30C649]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__system_us__Creat__6B24EA82]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Creat__6B24EA82]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Creat__6B24EA82]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__system_us__Modif__6C190EBB]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Modif__6C190EBB]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Modif__6C190EBB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__system_us__Modif__6D0D32F4]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__system_us__Modif__6D0D32F4]') AND parent_object_id = OBJECT_ID(N'[dbo].[system_user_role]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__system_us__Modif__6D0D32F4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[system_user_role] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__systemcus__Title__0880433F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Title__0880433F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Title__0880433F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Title__0880433F]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__systemcus__Statu__09746778]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Statu__09746778]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Statu__09746778]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Statu__09746778]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__systemcus__LinkM__0A688BB1]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__LinkM__0A688BB1]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__LinkM__0A688BB1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__LinkM__0A688BB1]  DEFAULT ('') FOR [LinkMan]
END


End
GO
/****** Object:  Default [DF__systemcus__Phone__0B5CAFEA]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Phone__0B5CAFEA]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Phone__0B5CAFEA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Phone__0B5CAFEA]  DEFAULT ('') FOR [Phone]
END


End
GO
/****** Object:  Default [DF__systemcus__Mobil__0C50D423]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Mobil__0C50D423]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Mobil__0C50D423]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Mobil__0C50D423]  DEFAULT ('') FOR [MobilePhone]
END


End
GO
/****** Object:  Default [DF__systemcustom__QQ__0D44F85C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcustom__QQ__0D44F85C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcustom__QQ__0D44F85C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcustom__QQ__0D44F85C]  DEFAULT ('') FOR [QQ]
END


End
GO
/****** Object:  Default [DF__systemcusto__Fax__0E391C95]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcusto__Fax__0E391C95]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcusto__Fax__0E391C95]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcusto__Fax__0E391C95]  DEFAULT ('') FOR [Fax]
END


End
GO
/****** Object:  Default [DF_systemcustomer_Email]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_Email]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_Email]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_Email]  DEFAULT ('') FOR [Email]
END


End
GO
/****** Object:  Default [DF__systemcus__Addre__0F2D40CE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Addre__0F2D40CE]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Addre__0F2D40CE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Addre__0F2D40CE]  DEFAULT ('') FOR [Address]
END


End
GO
/****** Object:  Default [DF__systemcus__Order__10216507]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Order__10216507]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Order__10216507]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Order__10216507]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF_systemcustomer_ProvinceID]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_ProvinceID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_ProvinceID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_ProvinceID]  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF_systemcustomer_CityID]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_CityID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_CityID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_CityID]  DEFAULT ((0)) FOR [CityID]
END


End
GO
/****** Object:  Default [DF_systemcustomer_CountyID]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_CountyID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_CountyID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_CountyID]  DEFAULT ((0)) FOR [CountyID]
END


End
GO
/****** Object:  Default [DF_systemcustomer_TownID]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_TownID]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_TownID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_TownID]  DEFAULT ((0)) FOR [TownID]
END


End
GO
/****** Object:  Default [DF__systemcus__Remar__11158940]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Remar__11158940]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Remar__11158940]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Remar__11158940]  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF_systemcustomer_OpenStatus]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemcustomer_OpenStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemcustomer_OpenStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF_systemcustomer_OpenStatus]  DEFAULT ((0)) FOR [OpenStatus]
END


End
GO
/****** Object:  Default [DF__systemcus__Creat__1209AD79]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Creat__1209AD79]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Creat__1209AD79]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Creat__1209AD79]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__systemcus__Creat__12FDD1B2]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Creat__12FDD1B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Creat__12FDD1B2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Creat__12FDD1B2]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__systemcus__Modif__13F1F5EB]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Modif__13F1F5EB]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Modif__13F1F5EB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Modif__13F1F5EB]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__systemcus__Modif__14E61A24]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemcus__Modif__14E61A24]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemcustomer]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemcus__Modif__14E61A24]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemcustomer] ADD  CONSTRAINT [DF__systemcus__Modif__14E61A24]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__systemdom__Title__46E78A0C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Title__46E78A0C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Title__46E78A0C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__systemdom__Statu__47DBAE45]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Statu__47DBAE45]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Statu__47DBAE45]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__systemdom__Order__48CFD27E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Order__48CFD27E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Order__48CFD27E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__systemdom__Remar__49C3F6B7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Remar__49C3F6B7]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Remar__49C3F6B7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__systemdom__Creat__4AB81AF0]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Creat__4AB81AF0]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Creat__4AB81AF0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__systemdom__Creat__4BAC3F29]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Creat__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Creat__4BAC3F29]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__systemdom__Modif__4CA06362]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Modif__4CA06362]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Modif__4CA06362]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__systemdom__Modif__4D94879B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemdom__Modif__4D94879B]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemdomain]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemdom__Modif__4D94879B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemdomain] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__systemmen__Custo__52E34C9D]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Custo__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Custo__52E34C9D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Custo__52E34C9D]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__systemmen__Title__53D770D6]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Title__53D770D6]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Title__53D770D6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Title__53D770D6]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__systemmen__MenuU__54CB950F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__MenuU__54CB950F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__MenuU__54CB950F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__MenuU__54CB950F]  DEFAULT ('') FOR [MenuUrl]
END


End
GO
/****** Object:  Default [DF_systemmenu_Alt]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_Alt]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_Alt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF_systemmenu_Alt]  DEFAULT ('') FOR [Alt]
END


End
GO
/****** Object:  Default [DF_systemmenu_IsSuperAdmin]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_IsSuperAdmin]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_IsSuperAdmin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF_systemmenu_IsSuperAdmin]  DEFAULT ((0)) FOR [IsSuperAdmin]
END


End
GO
/****** Object:  Default [DF__systemmen__IsTop__55BFB948]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__IsTop__55BFB948]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__IsTop__55BFB948]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__IsTop__55BFB948]  DEFAULT ((0)) FOR [IsTopMenu]
END


End
GO
/****** Object:  Default [DF__systemmen__TopMe__56B3DD81]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__TopMe__56B3DD81]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__TopMe__56B3DD81]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__TopMe__56B3DD81]  DEFAULT ((0)) FOR [TopMenuID]
END


End
GO
/****** Object:  Default [DF__systemmen__Paren__57A801BA]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Paren__57A801BA]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Paren__57A801BA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Paren__57A801BA]  DEFAULT ((0)) FOR [ParentId]
END


End
GO
/****** Object:  Default [DF_systemmenu_MenuType]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemmenu_MenuType]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemmenu_MenuType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF_systemmenu_MenuType]  DEFAULT ('') FOR [MenuType]
END


End
GO
/****** Object:  Default [DF__systemmen__Statu__59904A2C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Statu__59904A2C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Statu__59904A2C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Statu__59904A2C]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__systemmen__Order__5A846E65]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Order__5A846E65]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Order__5A846E65]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Order__5A846E65]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__systemmen__Remar__5B78929E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Remar__5B78929E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Remar__5B78929E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Remar__5B78929E]  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__systemmen__Creat__5C6CB6D7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Creat__5C6CB6D7]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Creat__5C6CB6D7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Creat__5C6CB6D7]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__systemmen__Creat__5D60DB10]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Creat__5D60DB10]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Creat__5D60DB10]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Creat__5D60DB10]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__systemmen__Modif__5E54FF49]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Modif__5E54FF49]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Modif__5E54FF49]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Modif__5E54FF49]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__systemmen__Modif__5F492382]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemmen__Modif__5F492382]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemmen__Modif__5F492382]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemmenu] ADD  CONSTRAINT [DF__systemmen__Modif__5F492382]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__systemrol__Custo__276EDEB3]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Custo__276EDEB3]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Custo__276EDEB3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__systemrol__Title__286302EC]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Title__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Title__286302EC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__systemrol__Statu__29572725]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Statu__29572725]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Statu__29572725]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__systemrol__Order__2A4B4B5E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Order__2A4B4B5E]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Order__2A4B4B5E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__systemrol__Remar__2B3F6F97]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Remar__2B3F6F97]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Remar__2B3F6F97]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__systemrol__Creat__2C3393D0]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Creat__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Creat__2C3393D0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__systemrol__Creat__2D27B809]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Creat__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Creat__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__systemrol__Modif__2E1BDC42]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Modif__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Modif__2E1BDC42]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__systemrol__Modif__2F10007B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemrol__Modif__2F10007B]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemrole]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemrol__Modif__2F10007B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemrole] ADD  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__systemuse__Custo__251C81ED]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Custo__251C81ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Custo__251C81ED]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Custo__251C81ED]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__systemuse__Title__2610A626]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Title__2610A626]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Title__2610A626]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Title__2610A626]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF_systemuser_Password]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_Password]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_Password]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF_systemuser_Password]  DEFAULT ('') FOR [UserPassword]
END


End
GO
/****** Object:  Default [DF_systemuser_RealName]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_RealName]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_RealName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF_systemuser_RealName]  DEFAULT ('') FOR [RealName]
END


End
GO
/****** Object:  Default [DF_systemuser_IdentityCard]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_IdentityCard]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_IdentityCard]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF_systemuser_IdentityCard]  DEFAULT ('') FOR [IdentityCard]
END


End
GO
/****** Object:  Default [DF_systemuser_UserSex]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_UserSex]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_UserSex]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF_systemuser_UserSex]  DEFAULT ('') FOR [UserSex]
END


End
GO
/****** Object:  Default [DF__systemuse__Statu__2704CA5F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Statu__2704CA5F]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Statu__2704CA5F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Statu__2704CA5F]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__systemuse__Phone__27F8EE98]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Phone__27F8EE98]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Phone__27F8EE98]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Phone__27F8EE98]  DEFAULT ('') FOR [Phone]
END


End
GO
/****** Object:  Default [DF__systemuse__Mobil__28ED12D1]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Mobil__28ED12D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Mobil__28ED12D1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Mobil__28ED12D1]  DEFAULT ('') FOR [MobilePhone]
END


End
GO
/****** Object:  Default [DF__systemuser__QQ__29E1370A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuser__QQ__29E1370A]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuser__QQ__29E1370A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuser__QQ__29E1370A]  DEFAULT ('') FOR [UserQQ]
END


End
GO
/****** Object:  Default [DF_systemuser_UserEmail]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_systemuser_UserEmail]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_systemuser_UserEmail]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF_systemuser_UserEmail]  DEFAULT ('') FOR [UserEmail]
END


End
GO
/****** Object:  Default [DF__systemuse__Addre__2AD55B43]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Addre__2AD55B43]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Addre__2AD55B43]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Addre__2AD55B43]  DEFAULT ('') FOR [Address]
END


End
GO
/****** Object:  Default [DF__systemuse__Order__2BC97F7C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Order__2BC97F7C]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Order__2BC97F7C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Order__2BC97F7C]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__systemuse__Remar__2CBDA3B5]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Remar__2CBDA3B5]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Remar__2CBDA3B5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Remar__2CBDA3B5]  DEFAULT ('') FOR [Remark]
END


End
GO
/****** Object:  Default [DF__systemuse__Creat__2DB1C7EE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Creat__2DB1C7EE]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Creat__2DB1C7EE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Creat__2DB1C7EE]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__systemuse__Creat__2EA5EC27]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Creat__2EA5EC27]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Creat__2EA5EC27]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Creat__2EA5EC27]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__systemuse__Modif__2F9A1060]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Modif__2F9A1060]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Modif__2F9A1060]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Modif__2F9A1060]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__systemuse__Modif__308E3499]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__systemuse__Modif__308E3499]') AND parent_object_id = OBJECT_ID(N'[dbo].[systemuser]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__systemuse__Modif__308E3499]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[systemuser] ADD  CONSTRAINT [DF__systemuse__Modif__308E3499]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__web_custo__MenuI__6C390A4C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__MenuI__6C390A4C]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__MenuI__6C390A4C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__MenuI__6C390A4C]  DEFAULT ((0)) FOR [MenuID]
END


End
GO
/****** Object:  Default [DF__web_custo__Custo__6D2D2E85]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Custo__6D2D2E85]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Custo__6D2D2E85]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Custo__6D2D2E85]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__web_custo__Statu__6F1576F7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Statu__6F1576F7]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Statu__6F1576F7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Statu__6F1576F7]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__web_custo__Order__70099B30]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Order__70099B30]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Order__70099B30]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Order__70099B30]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF_web_customer_menu_CreatorID]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_web_customer_menu_CreatorID]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_web_customer_menu_CreatorID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF_web_customer_menu_CreatorID]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__web_custo__Creat__70FDBF69]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Creat__70FDBF69]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Creat__70FDBF69]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Creat__70FDBF69]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__web_custo__Modif__71F1E3A2]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Modif__71F1E3A2]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Modif__71F1E3A2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Modif__71F1E3A2]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__web_custo__Modif__72E607DB]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__web_custo__Modif__72E607DB]') AND parent_object_id = OBJECT_ID(N'[dbo].[web_customer_menu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__web_custo__Modif__72E607DB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[web_customer_menu] ADD  CONSTRAINT [DF__web_custo__Modif__72E607DB]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__beautiful__Title__02C769E9]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Title__02C769E9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Title__02C769E9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Title__02C769E9]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__beautiful__Custo__03BB8E22]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Custo__03BB8E22]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Custo__03BB8E22]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Custo__03BB8E22]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__beautiful__TownI__04AFB25B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__TownI__04AFB25B]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__TownI__04AFB25B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__TownI__04AFB25B]  DEFAULT ((0)) FOR [TownID]
END


End
GO
/****** Object:  Default [DF__beautiful__Villa__05A3D694]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Villa__05A3D694]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Villa__05A3D694]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Villa__05A3D694]  DEFAULT ((0)) FOR [VillageID]
END


End
GO
/****** Object:  Default [DF__beautiful__Statu__0697FACD]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Statu__0697FACD]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Statu__0697FACD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Statu__0697FACD]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF_webbeautifulvillage_Intro]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webbeautifulvillage_Intro]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webbeautifulvillage_Intro]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF_webbeautifulvillage_Intro]  DEFAULT ('') FOR [Intro]
END


End
GO
/****** Object:  Default [DF__beautiful__Yield__078C1F06]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Yield__078C1F06]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Yield__078C1F06]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Yield__078C1F06]  DEFAULT ('') FOR [Yield]
END


End
GO
/****** Object:  Default [DF__beautifulv__Live__0880433F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautifulv__Live__0880433F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautifulv__Live__0880433F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautifulv__Live__0880433F]  DEFAULT ('') FOR [Live]
END


End
GO
/****** Object:  Default [DF__beautiful__Envir__09746778]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Envir__09746778]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Envir__09746778]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Envir__09746778]  DEFAULT ('') FOR [Environment]
END


End
GO
/****** Object:  Default [DF__beautiful__Human__0A688BB1]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Human__0A688BB1]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Human__0A688BB1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Human__0A688BB1]  DEFAULT ('') FOR [Humanism]
END


End
GO
/****** Object:  Default [DF__beautiful__Order__0B5CAFEA]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Order__0B5CAFEA]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Order__0B5CAFEA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Order__0B5CAFEA]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__beautiful__Creat__0C50D423]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Creat__0C50D423]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Creat__0C50D423]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Creat__0C50D423]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__beautiful__Creat__0D44F85C]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Creat__0D44F85C]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Creat__0D44F85C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Creat__0D44F85C]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__beautiful__Modif__0E391C95]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Modif__0E391C95]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Modif__0E391C95]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Modif__0E391C95]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__beautiful__Modif__0F2D40CE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__beautiful__Modif__0F2D40CE]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillage]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__beautiful__Modif__0F2D40CE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillage] ADD  CONSTRAINT [DF__beautiful__Modif__0F2D40CE]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__webbeauti__Title__6319B466]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Title__6319B466]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Title__6319B466]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Title__6319B466]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__webbeauti__Custo__640DD89F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Custo__640DD89F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Custo__640DD89F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Custo__640DD89F]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__webbeauti__TownI__6501FCD8]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__TownI__6501FCD8]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__TownI__6501FCD8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__TownI__6501FCD8]  DEFAULT ((0)) FOR [TownID]
END


End
GO
/****** Object:  Default [DF__webbeauti__Villa__65F62111]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Villa__65F62111]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Villa__65F62111]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Villa__65F62111]  DEFAULT ((0)) FOR [VillageID]
END


End
GO
/****** Object:  Default [DF__webbeauti__Statu__66EA454A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Statu__66EA454A]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Statu__66EA454A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Statu__66EA454A]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__webbeauti__FileT__67DE6983]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileT__67DE6983]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileT__67DE6983]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__FileT__67DE6983]  DEFAULT ('') FOR [FileType]
END


End
GO
/****** Object:  Default [DF__webbeauti__FileU__68D28DBC]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileU__68D28DBC]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileU__68D28DBC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__FileU__68D28DBC]  DEFAULT ('') FOR [FileUrl]
END


End
GO
/****** Object:  Default [DF_webbeautifulvillageFile_LinkUrl]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webbeautifulvillageFile_LinkUrl]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webbeautifulvillageFile_LinkUrl]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF_webbeautifulvillageFile_LinkUrl]  DEFAULT ('') FOR [LinkUrl]
END


End
GO
/****** Object:  Default [DF__webbeauti__FileR__69C6B1F5]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__FileR__69C6B1F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__FileR__69C6B1F5]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__FileR__69C6B1F5]  DEFAULT ('') FOR [FileRmark]
END


End
GO
/****** Object:  Default [DF__webbeauti__Order__6ABAD62E]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Order__6ABAD62E]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Order__6ABAD62E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Order__6ABAD62E]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__webbeauti__Creat__6BAEFA67]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Creat__6BAEFA67]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Creat__6BAEFA67]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Creat__6BAEFA67]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__webbeauti__Creat__6CA31EA0]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Creat__6CA31EA0]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Creat__6CA31EA0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Creat__6CA31EA0]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__webbeauti__Modif__6D9742D9]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Modif__6D9742D9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Modif__6D9742D9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Modif__6D9742D9]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__webbeauti__Modif__6E8B6712]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webbeauti__Modif__6E8B6712]') AND parent_object_id = OBJECT_ID(N'[dbo].[webbeautifulvillageFile]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webbeauti__Modif__6E8B6712]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webbeautifulvillageFile] ADD  CONSTRAINT [DF__webbeauti__Modif__6E8B6712]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__webfarmin__Custo__70A8B9AE]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Custo__70A8B9AE]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Custo__70A8B9AE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Custo__70A8B9AE]  DEFAULT ((0)) FOR [CustomerID]
END


End
GO
/****** Object:  Default [DF__webfarmin__Title__719CDDE7]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Title__719CDDE7]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Title__719CDDE7]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Title__719CDDE7]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__webfarmin__Conte__72910220]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Conte__72910220]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Conte__72910220]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Conte__72910220]  DEFAULT ('') FOR [Content]
END


End
GO
/****** Object:  Default [DF__webfarmin__Opert__73852659]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Opert__73852659]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Opert__73852659]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Opert__73852659]  DEFAULT ('0') FOR [Opertype]
END


End
GO
/****** Object:  Default [DF__webfarmin__Statu__74794A92]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Statu__74794A92]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Statu__74794A92]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Statu__74794A92]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF__webfarmin__Order__756D6ECB]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Order__756D6ECB]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Order__756D6ECB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Order__756D6ECB]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__webfarmin__Provi__76619304]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Provi__76619304]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Provi__76619304]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Provi__76619304]  DEFAULT ((0)) FOR [ProvinceID]
END


End
GO
/****** Object:  Default [DF__webfarmin__CityI__7755B73D]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__CityI__7755B73D]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__CityI__7755B73D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__CityI__7755B73D]  DEFAULT ((0)) FOR [CityID]
END


End
GO
/****** Object:  Default [DF__webfarmin__Count__7849DB76]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Count__7849DB76]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Count__7849DB76]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Count__7849DB76]  DEFAULT ((0)) FOR [CountyID]
END


End
GO
/****** Object:  Default [DF__webfarmin__TownI__793DFFAF]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__TownI__793DFFAF]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__TownI__793DFFAF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__TownI__793DFFAF]  DEFAULT ((0)) FOR [TownID]
END


End
GO
/****** Object:  Default [DF__webfarmin__Villa__7A3223E8]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Villa__7A3223E8]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Villa__7A3223E8]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Villa__7A3223E8]  DEFAULT ((0)) FOR [VillageID]
END


End
GO
/****** Object:  Default [DF__webfarmin__Creat__7B264821]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Creat__7B264821]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Creat__7B264821]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Creat__7B264821]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__webfarmin__Creat__7C1A6C5A]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Creat__7C1A6C5A]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Creat__7C1A6C5A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Creat__7C1A6C5A]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__webfarmin__Modif__7D0E9093]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Modif__7D0E9093]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Modif__7D0E9093]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Modif__7D0E9093]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__webfarmin__Modif__7E02B4CC]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webfarmin__Modif__7E02B4CC]') AND parent_object_id = OBJECT_ID(N'[dbo].[webfarmingnews]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webfarmin__Modif__7E02B4CC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webfarmingnews] ADD  CONSTRAINT [DF__webfarmin__Modif__7E02B4CC]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
/****** Object:  Default [DF__webmenu__Title__61BB7BD9]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Title__61BB7BD9]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Title__61BB7BD9]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__Title__61BB7BD9]  DEFAULT ('') FOR [Title]
END


End
GO
/****** Object:  Default [DF__webmenu__Status__62AFA012]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Status__62AFA012]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Status__62AFA012]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__Status__62AFA012]  DEFAULT ((0)) FOR [Status]
END


End
GO
/****** Object:  Default [DF_webmenu_Url]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_webmenu_Url]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_webmenu_Url]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF_webmenu_Url]  DEFAULT ('') FOR [Url]
END


End
GO
/****** Object:  Default [DF__webmenu__OrderVa__63A3C44B]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__OrderVa__63A3C44B]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__OrderVa__63A3C44B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__OrderVa__63A3C44B]  DEFAULT ((0)) FOR [OrderValue]
END


End
GO
/****** Object:  Default [DF__webmenu__Creator__6497E884]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Creator__6497E884]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Creator__6497E884]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__Creator__6497E884]  DEFAULT ((0)) FOR [CreatorID]
END


End
GO
/****** Object:  Default [DF__webmenu__CreateD__658C0CBD]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__CreateD__658C0CBD]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__CreateD__658C0CBD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__CreateD__658C0CBD]  DEFAULT ('2012-8-16 00:00:00') FOR [CreateDate]
END


End
GO
/****** Object:  Default [DF__webmenu__Modifie__668030F6]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__Modifie__668030F6]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__Modifie__668030F6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__Modifie__668030F6]  DEFAULT ((0)) FOR [Modifier]
END


End
GO
/****** Object:  Default [DF__webmenu__ModifyD__6774552F]    Script Date: 10/10/2013 22:27:38 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__webmenu__ModifyD__6774552F]') AND parent_object_id = OBJECT_ID(N'[dbo].[webmenu]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__webmenu__ModifyD__6774552F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[webmenu] ADD  CONSTRAINT [DF__webmenu__ModifyD__6774552F]  DEFAULT ('2012-8-16 00:00:00') FOR [ModifyDate]
END


End
GO
