Public Class SourceMdlIkChain53

	'struct mstudioikchain_t
	'{
	'	DECLARE_BYTESWAP_DATADESC();
	'	int				sznameindex;
	'	inline char * const pszName( void ) const { return ((char *)this) + sznameindex; }
	'	int				linktype;
	'	int				numlinks;
	'	int				linkindex;
	'	inline mstudioiklink_t *pLink( int i ) const { return (mstudioiklink_t *)(((byte *)this) + linkindex) + i; };
	'	// FIXME: add unused entries
	'};


	'	int				sznameindex;
	Public nameOffset As Integer
	'	int				linktype;
	Public linkType As Integer
	'	int				numlinks;
	Public linkCount As Integer
	'	int				linkindex;
	Public linkOffset As Integer
	'	Vector	kneeDir;	// ideal bending direction (per link, if applicable)
	Public idealBendingDirection As New SourceVector()
	'	int
	Public unk As New Integer

	'	inline char * const pszName( void ) const { return ((char *)this) + sznameindex; }
	Public theName As String
	Public theLinks As List(Of SourceMdlIkLink53)

End Class
